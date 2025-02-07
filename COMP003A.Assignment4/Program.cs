/*
 Author: Victor Flores
Course: COMP-003A
Faculty: Jonathon Cruz
Purpose: Inventory management application with a minimum of 10 elements in the collection.
*/
using System.Xml.Serialization;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the Inventory Management System!");
            int choice;
            int done;

            List<string> productNames = new List<string>();//list of product names
            List<int> productQuantities = new List<int>();//list of quantities
         


           int index = productNames.IndexOf("Apples");
           if (index != -1)
           {
               productQuantities[index] = 50;
           }
           else
           {
               Console.WriteLine("Product not found!");
           }



            while (true)
            {
                Console.WriteLine("Inventory Management System Menu: ");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());



                if (choice == 4) break;

                if (choice == 1)
                {
                    
                    Console.Write("\nEnter product name: ");
                    productNames.Add(Console.ReadLine());
                    Console.Write("Enter proudct quanity: ");
                    productQuantities.Add(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Product added successfully!\n");

                }
                
                if (choice == 2)
                {
                    Console.Write("Enter product to remove: ");
                    productNames.Remove(Console.ReadLine());
                    Console.Write("How many? ");
                    productQuantities.Remove(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Update successful!");
                }

                if (choice == 3)
                {
                    Console.WriteLine("Inventory Summary:");
                    Console.WriteLine($"");
                    Console.WriteLine($"Total product: {productNames.Count}");
                    Console.WriteLine($"Total Quantity: {productQuantities.Count}");
                    Console.WriteLine($"Average Quantity: \n");
                }
            }
        }
    }
}
