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
                    List<string> productNames = new List<string>();
                    List<int> productQuantities = new List<int>();

                    foreach (string name in productNames)
                        {
                            Console.WriteLine(name);
                        }
                    Console.Write("\nEnter product name: ");
                    productNames.Add(Console.ReadLine());
                    Console.Write("Enter proudct quanity: ");
                    productQuantities.Add(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Product added successfully!\n");

                }
                
                if (choice == 2)
                {

                }

                if (choice == 3)
                {
                 
                }
            }
        }
    }
}
