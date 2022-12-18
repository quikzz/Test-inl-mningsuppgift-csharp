using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;
using Test_inlämningsuppgift_csharp.Products;

namespace Test_inlämningsuppgift_csharp
{
    public abstract class Product
    {
        public abstract string name { get; }
        public abstract int price { get; }
        public abstract string description { get; }

    }

  
}
