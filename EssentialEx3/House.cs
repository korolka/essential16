using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialEx3
{
    internal class House : ICloneable
    {
        private Adress adress;
        private Cost cost;

        public Adress Adress
        {
            get { return adress; }
            set
            {
                if (value != null)
                    adress = value;
            }
        }
        public Cost Cost
        {
            get { return cost; }
            set
            {
                if (value != null)
                    cost = value;
            }
        }

        public House(string adress,int cost) 
        {
            Cost = new Cost(cost);
            Adress = new Adress(adress);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object DeepClone()
        {
            return new House(Adress.AdressVariable,Cost.CostVariable);
        }

    }
}
