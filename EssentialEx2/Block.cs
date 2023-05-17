using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Essential16
{
    internal class Block
    {
        private double a, b, c, d;


        public Block(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override bool Equals(object other)
        {
            if (other is Block)
            {
                Block otherBlock = (Block)other;
                return this.a == otherBlock.a && b == otherBlock.b && c == otherBlock.c && d == otherBlock.d;
            }
            else
            {
                Console.WriteLine("Object don`t be c converted to Block");
                return false;
            }
        }

        //public override int GetHashCode()
        //{
        //    return a.GetHashCode() ^ b.GetHashCode();
        //}

        public override string ToString()
        {
            return string.Format("Block {0} = {1}, {2}, {3}, {4}", this.GetHashCode(), a, b, c, d);
        }
    }
}
