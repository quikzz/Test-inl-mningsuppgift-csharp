using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Products
{
    public class Snus : Product, IInterface
    {
        public override string name => "Snus";

        public override int price => 45;

        public override string description => "Pouches with tobacco and nicotine";

        public void Buy()
        {
            Console.WriteLine("You have bought snus, enjoy!");
        }

        public void Description()
        {
            Console.WriteLine("Pouches with tobacco and nicotine");
        }

        public void Use()
        {
            Console.WriteLine("*Puts a snus under your lip... and awaits the nicotine kick*");
        }
    }
}
