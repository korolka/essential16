using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialEx3
{
    internal class Adress
    {
        private string adress;

        public string AdressVariable
        {
            get { return adress; }
            set { adress = value; }
        }


        public Adress(string adress)
        {
            this.adress = adress;
        }
    }
}
