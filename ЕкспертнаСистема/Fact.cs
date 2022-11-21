using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ЭС
{
    [Serializable]
    public class Fact :IComparable
    {

        private Variable v;
        private string weight;
        private Rightly truly;

        #region Свойства

        public Variable V
        {
            get { return v;}
            set { v = value; }
        }


        public string Weight
        {
            get { return weight; }
            set 
            {
                if (v.Domain.InDomain(value))
                {
                    weight = value;
                    truly = Rightly.Unknown; // считаем неизвестным
                }
                else
                    throw new DomainException("Попытка присвоить переменной значение не из ее домена");
            }
        }


        public Rightly Truly
        {
            get { return truly; }
            set { truly = value; }
        }

        #endregion

        

        #region Конструкторы
        public Fact()
        {
        }

        public Fact(Variable v, string weight)
        {
            this.V = v;
            this.Weight = weight;
            truly = Rightly.Unknown;
        }

        public Fact(Variable v, string weight, Rightly truly) 
            :this(v, weight)
        {
            this.Truly = truly;
        }
        #endregion

        public override string ToString()
        {
            return this.v.Name + " = " + this.weight;// +" (" + truly + ")";
        }

        public int CompareTo(object obj)
        {
            Fact f = obj as Fact;
            int i = this.V.CompareTo(f.V);
            if (i != 0)
                return i;
            else 
                return this.weight.CompareTo(f.Weight);
        }

        internal static bool ContainsIn(Fact fact, params Fact[] fArr)
        {
            foreach (Fact same in fArr)
                if (fact.CompareTo(same) == 0)
                    return true;

            return false;
        }

        internal static Fact GetFromMas(Fact fact, params Fact[] fArr)
        {
            foreach (Fact same in fArr)
                if (fact.CompareTo(same) == 0)
                    return same;
            return null;
        }
    }

   

}
