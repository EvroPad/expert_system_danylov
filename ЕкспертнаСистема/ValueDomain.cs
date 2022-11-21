using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ЭС
{
    [Serializable]
    public class ValueDomain
    {
       
        private List<string> listVal = new List<string>();
        private string name = "Noname";

        #region Конструктор
        public ValueDomain()
        {
        }
        public ValueDomain(string name)
        {
            this.name = name;
        }
        #endregion

        #region Свойства
        public List<string> ListVal
        {
            get { return listVal; }
            set { listVal = value; }
        }

        public int Count
        {
            get { return listVal.Count; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        public string GetVal(int pos)
        {
            if ((pos > listVal.Count - 1) || (pos < 0))
                throw new DomainException("Індекс знаходився поза межами списку значень");
            return listVal[pos];
        }

        public void AddVal(string val, int pos)
        {
            if (listVal.Contains(val))
                throw new DomainException("Спроба додати повторюване значення домен");
            if ((pos > listVal.Count) || (pos < 0))
                throw new DomainException("Індекс знаходився поза межами списку значень");
            listVal.Add(val);
            Move(listVal.Count - 1, pos);
        }

        public void Move (int oldPos, int newPos)
        {
            if ((oldPos > listVal.Count - 1) || (newPos > listVal.Count - 1) || (oldPos < 0) || (newPos < 0))
                throw new DomainException("Індекс знаходився поза межами списку значень");

            string pr = listVal[oldPos];
            if (oldPos > newPos)
            {
                for (int i = oldPos; i > newPos; i--)
                    listVal[i] = listVal[i - 1];
            }
            else 
            {
                for (int i = oldPos; i < newPos; i++)
                    listVal[i] = listVal[i + 1];
            }
            listVal[newPos] = pr;
        }

        public void Move(string val, int newPos)
        {
            if (listVal.Contains(val))
                Move(listVal.IndexOf(val), newPos);
            else
                throw new DomainException("Список значень не містить необхідного елемента");
        }

        public void Remove(int pos)
        {
            if ((pos > listVal.Count - 1) || (pos < 0))
                throw new DomainException("Індекс знаходився поза межами списку значень");
            listVal.RemoveAt(pos);
        }

        public void Remove(string val)
        {
            if (listVal.Contains(val))
                listVal.Remove(val);
            else
                throw new DomainException("Список значень не містить необхідного елемента");
        }

        public bool InDomain(string val)
        {
            return listVal.Contains(val);
        }

        public int IndexOf(string val)
        {
            return listVal.IndexOf(val);
        }


        public override string ToString()
        {
            string res = "";
            if (listVal.Count > 0)
            {
                for (int i = 0; i < listVal.Count - 1; i++)
                    res += listVal[i] + " ";
                res += listVal[listVal.Count - 1];
            }
            else
                res = "Empty";
            return res;
        }


    }
}
