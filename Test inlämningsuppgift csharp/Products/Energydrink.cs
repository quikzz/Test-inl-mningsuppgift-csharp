using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{
    public class Energydrink : Product, IInterface
    {
      
        public override string name => "Energy drink";
        public override int price => 15;
        public override string description => "Carbonated drink with caffeine";

        public void Buy()
        {
            Console.WriteLine("You have bought an Energy drink!");
        }

        public void Description()
        {
            Console.WriteLine("You dont want to know what it contains... :)");
        }

        public void Use()
        {
            Console.WriteLine("*Drinking energy drink... you can feel the energy level rising*");
        }
    }
}
