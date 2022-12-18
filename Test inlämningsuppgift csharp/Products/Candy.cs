using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{
    public class Candy : Product, IInterface
    {
        public override string name => "Candy";

        public override int price => 12;

        public override string description => "Mix of sweet and sour candy";

        public void Buy()
        {
            Console.WriteLine("You have bought a candy bag, enjoy!");
        }

        public void Description()
        {
            Console.WriteLine("A bag of sweet and sour candy");
        }
        
        public void Use()
        {
            Console.WriteLine("*Eating candy... while not trying to do crazy face expressions*");
        }
    }
}
