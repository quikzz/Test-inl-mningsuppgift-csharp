using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{
    public class Icecoffee : Product, IInterface
    {
        public override string name => "Ice coffee";

        public override int price => 15;

        public override string description => "Cold caffeinated coffee";

        public void Buy()
        {
            Console.WriteLine("You have bought ice coffee, enjoy!");
        }

        public void Description()
        {
            Console.WriteLine("Ice cold coffee with flavour of salted caramel and vanilla");
        }

        public void Use()
        {
            Console.WriteLine("*Drinking ice coffee... delicious!*");
        }
    }
}
