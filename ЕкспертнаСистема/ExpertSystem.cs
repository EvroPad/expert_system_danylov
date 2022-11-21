using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using System.Reflection;
using System.Windows.Forms;

namespace ЭС
{
    [Serializable]
    public class ExpertSystem
    {        
        private OrderedDictionary<string, ValueDomain> domains = new OrderedDictionary<string, ValueDomain>();
        private OrderedDictionary<string, Variable> vars = new OrderedDictionary<string, Variable>();
        private OrderedDictionary<string, Rule> rules = new OrderedDictionary<string, Rule>();
        private Variable goal;
        private List<Fact> proved = new List<Fact>();
        private List<Rule> workedRules;
        public string res;
        



        #region Свойства
        public List<Rule> WorkedRules
        {
            get { return workedRules; }
        }

        public List<Fact> Proved
        {
            get { return proved; }
        }

        public Variable Goal
        {
            get { return goal; }
            set { goal = value; }
        }

        public OrderedDictionary<string, ValueDomain> Domains
        {
            get { return domains; }
            set { domains = value; }
        }

        public OrderedDictionary<string, Variable> Vars
        {
            get { return vars; }
            set { vars = value; }
        }

        public OrderedDictionary<string, Rule> Rules
        {
            get { return rules; }
            set { rules = value; }
        }
        #endregion

        #region Конструктор
        public ExpertSystem()
        { 
        }
        #endregion

        public Fact GoConsult()
        {
            proved = new List<Fact>();
            workedRules = new List<Rule>();
            foreach (Rule r in rules.Vals)
                r.Worked = RuleWork.No;
            return Consult(goal);
        }

        public Rightly DoRule(Rule r)
        {
            bool verno = true;
            foreach (Fact fact in r.Reasons)
            {
                if (!Fact.ContainsIn(fact, proved.ToArray()))
                {
                    Fact f = Consult(fact.V); 
                    proved.Add(f);
                    if (f.Truly == Rightly.Yes)
                        verno = (fact.CompareTo(f) == 0);
                    else
                        verno = false;
                    foreach (string s in f.V.Domain.ListVal)
                    {
                        if (s != f.Weight)
                            proved.Add(new Fact(f.V, s, Rightly.No));
                    }

                    if (!verno)
                        break; 
                }
                else
                { 
                    if (Fact.GetFromMas(fact, proved.ToArray()).Truly == Rightly.Yes)
                        verno = true;
                    else
                    {
                        verno = false;
                        break;
                    }
                }
            }

            if (verno) 
            {
                if (r.Result == null || !r.Result.V.Domain.ListVal.Contains(r.Result.Weight))
                {
                    throw new DomainException("Правило " + r.Name + " намагається надати значення не з домену!");
                }
                r.Result.Truly = Rightly.Yes;
                proved.Add(r.Result);
                r.Worked = RuleWork.Signifi; 
                workedRules.Add(r);
                return Rightly.Yes;
            }
            else
            {
                r.Worked = RuleWork.Unsignify; 
                return Rightly.Unknown;
            }
        }

        private Fact Consult(Variable g)
        {
            if (g.Domain == null)
                throw new DomainException("У змінної \"" + g.Name + "\" невідомий домен!");
            if (g.Domain.ListVal.Count == 0)
                throw new DomainException("Домен \"" + g.Domain.Name + "\" не має значень!");

            if (g.MyType == VarType.Queried)
            {              
                frmQuestion fq = new frmQuestion(g, this);
                fq.ShowDialog();
                Fact f = new Fact(g, res as string, Rightly.Yes);
                return f;
            }
            else
            {
                foreach (string s in rules.Keys) 
                {
                    if (rules[s].Result != null && rules[s].Result.V.CompareTo(g) == 0)
                    {
                        switch (DoRule(rules[s]))
                        {
                            case Rightly.Unknown:
                                if (g.MyType == VarType.DeductionQueried)
                                {
                                    frmQuestion fq = new frmQuestion(g, this);
                                    fq.ShowDialog();
                                    Fact f = new Fact(g, res as string, Rightly.Yes);
                                    return f;
                                }
                                continue;
                            default:
                                return rules[s].Result;
                        }
                    }
                }
            }

            return new Fact(g, g.Domain.GetVal(0), Rightly.Unknown);
        }



    }

}
