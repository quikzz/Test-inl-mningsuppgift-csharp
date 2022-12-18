using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{
    public class Water : Product, IInterface
    {
        public override string name => "Water";

        public override int price => 10;

        public override string description => "Non-carbonated fresh water";

        public void Buy()
        {
            Console.WriteLine("You have bought a bottle of water, enjoy!");
        }

        public void Description()
        {
            Console.WriteLine("Thirst quenching water with water flavour :)");
        }

        public void Use()
        {
            Console.WriteLine("*Drinking water... you feel refreshed*");
        }
    }
}
