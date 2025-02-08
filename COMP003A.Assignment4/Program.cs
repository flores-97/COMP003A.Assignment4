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


            while (true)
                {
                    Console.WriteLine("\nInventory Management System Menu: ");
                    Console.WriteLine("1. Add a Product");
                    Console.WriteLine("2. Update Product Quantity");
                    Console.WriteLine("3. View Inventory Summary");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice: ");

                    choice = int.Parse(Console.ReadLine());



                if (choice == 4) break;

                else if (choice == 1)
                {

                    Console.Write("\nEnter product name: ");
                    productNames.Add(Console.ReadLine());
                    Console.Write("Enter proudct quantity: ");// needs error if quantity is negative then add to option 2 
                    productQuantities.Add(int.Parse(Console.ReadLine()));

                }

                else if (choice == 2)
                {
                    Console.Write("Which item would you like to update? ");
                    productNames.IndexOf("productNames").ToString(Console.ReadLine());//needs error message if item not found
                    
                    Console.Write("How many would you like to add? ");
                    productQuantities.Add(int.Parse((string)Console.ReadLine()));
                }


                    else if (choice == 3)
                    {
                   
                        Console.WriteLine("\nInventory Summary:");
                        Console.WriteLine($"{Display}");//needs to display item/quantity
                        Console.WriteLine($"Total product: {productNames.Count}");
                        Console.WriteLine($"Total Quantity: {productQuantities.Sum()}");
                        Console.WriteLine($"Average Quantity:  {productQuantities.Average()}\n");
                    }

                    else
                    {
                        Console.WriteLine("\nInvalid entry. Select an option on the menu.\n");
                    }
                }
            
        }
        public static void Display(string productNames, int productQuantities)

        {
            Console.WriteLine($"- {productNames}: ");
        }

        public static void Namesearch(string productNames, int productQuantities)

        {

            int index = productNames.IndexOf(productNames);
            if (index != -1)
            {
                productQuantities = 100;
            }
            else
            {
                Console.WriteLine("Product not found!");
            }

           
        }
    }
}
