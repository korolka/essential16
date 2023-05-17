using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialEx3
{
    internal class Cost
    {
        private int cost;

        public int CostVariable
        {
            get { return cost; }
            set { cost = value; }
        }
        public Cost(int cost)
        {
            this.cost = cost;
        }
    }
}
