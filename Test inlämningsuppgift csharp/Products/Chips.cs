using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;

namespace Test_inlämningsuppgift_csharp.Productclasses
{
    public class Chips : Product, IInterface
    {
        public override string name => "Chips";
        public override int price => 15;
        public override string description => "Crispy chips with sourcream and onion flavour";
        public void Buy()
        {
            Console.WriteLine("You have bought chips, enjoy!");
        }
        public void Description()
        {
            Console.WriteLine("Crispy chips with sourcream and onion flavour");
        }
        public void Use()
        {
            Console.WriteLine("*Eating chips... omnomnom*");
        }
    }
}
