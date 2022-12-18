using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_inlämningsuppgift_csharp.Interfaces
{
    public abstract class ProductTest
    {
        public string name;
        public int price;
        public string description;

        public ProductTest(string name, int price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public abstract void Buy();
        public abstract void Use();
        public abstract void Description();


    }
    public class Subproduct : ProductTest, IInterface
    {
        public Subproduct(string name, int price, string description) : base(name, price, description)
        {

        }

        public override void Buy()
        {
            throw new NotImplementedException();
        }

        public override void Description()
        {

        }

        public override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
