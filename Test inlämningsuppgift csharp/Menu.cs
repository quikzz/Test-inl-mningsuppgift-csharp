using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inlämningsuppgift_csharp.Interfaces;
using Test_inlämningsuppgift_csharp.Productclasses;
using Test_inlämningsuppgift_csharp.Products;

namespace Test_inlämningsuppgift_csharp
{
    public class Menu
    {
        
        public static void BeveragesMenu()
        {
            Console.Clear();

            var Beverages = new List<string>();
            Beverages.Add(new Energydrink().name);
            Beverages.Add(new Icecoffee().name);
            Beverages.Add(new Soda().name);
            Beverages.Add(new Water().name);

            var index = 1;

            Console.WriteLine("[MAIN MENU] > [BEVERAGES]\n");
            foreach (var item in Beverages)
            {
                Console.WriteLine($"{index}. {item}");
                index++;
            }
        }
        public static void SnackMenu()
        {
            Console.Clear();

            var Snack = new List<Tuple<string, int>>();
            Snack.Add(new Tuple<string, int>(new Snackbar().name, new Snackbar().price));
            Snack.Add(new Tuple<string, int>(new Candy().name, new Candy().price));
            Snack.Add(new Tuple<string, int>(new Chips().name, new Chips().price));
            Snack.Add(new Tuple<string, int>(new Chewinggum().name, new Chewinggum().price));

            var index = 1;
             Console.WriteLine("[MAIN MENU] > [SNACK]\n");
             foreach (var item in Snack)
             {
                Console.WriteLine($"{index}. {item.Item1} - {item.Item2} kr");
                index++;
             }

        }
        public static void TobaccoMenu()
        {
            Console.Clear();    
            
            // Creates a list of tuples that fetches property name and price, this will later be printed out.
            var Tobacco = new List<Tuple<string, int>>();
            Tobacco.Add(new Tuple<string, int>(new Cigarettes().name, new Cigarettes().price));
            Tobacco.Add(new Tuple<string, int>(new Snus().name, new Snus().price));
            Tobacco.Add(new Tuple<string, int>(new Nicotinegum().name, new Nicotinegum().price));

            var index = 1;
            Console.WriteLine("[MAIN MENU] > [TOBACCO]\n");

            // Prints out tuples list of Tobacco products with fetched names and prices properties from each class
            foreach (var item in Tobacco)
            {
                Console.WriteLine($"{index}. {item.Item1} - {item.Item2} kr");
                index++;
            }
          

        }
        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("[ MAIN MENU ]\n");
            Console.WriteLine("Choose from the menu below by pressing one of the following numbers\n");

            Console.WriteLine("1. Beverages");
            Console.WriteLine("2. Snack");
            Console.WriteLine("3. Tobacco");
            Console.WriteLine("4. Quit");
            
            int input;

            do
            {
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        BeveragesMenu();
                        break;
                    case 2:
                        Console.Clear();
                        SnackMenu();
                        break;
                    case 3:
                        Console.Clear();
                        TobaccoMenu();
                        break;
                    case 4:
                        break;

                    default:
                        Console.WriteLine("Option does not exists");
                        break;
                } 
            } while (input != 4);
        }

        
        public static void Options(Product produkt)
        {
            Console.Clear();  
   
            Console.WriteLine(produkt.name);

            

            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    
                    break;
                case 2:
                    Console.WriteLine(produkt.description);
                    break;

            }
        }
      
    }
}
