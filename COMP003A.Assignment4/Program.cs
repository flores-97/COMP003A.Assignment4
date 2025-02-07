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
            List<double> productQuantities = new List<double>();//list of quantities

            

            for (int i = 0; i < productQuantities.Count; i++)
            {


                int productQuantity = -1;
                while (productQuantity < 0 || productQuantity > 100)
                {
                    Console.WriteLine($"Enter quantity for {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out productQuantity))
                    {
                        if (productQuantity >= 0 && productQuantity <= 100)
                        {
                            productQuantities[i] = productQuantity;
                        }
                        else
                        {
                            Console.WriteLine("Quantity must be between 0 and 100)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        productQuantity = -1;
                    }
                }
            }

            double sum = 0;
            for (int i = 0; i < productQuantities.Count; i++)
            {
                sum += productQuantities[i];
            }
            double average = sum / productQuantities.Count;

            Console.WriteLine("\nQuantities: ");
            foreach (int productQuantity in productQuantities)
            {
                Console.WriteLine(productQuantity); 
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
                    Console.Write("Enter proudct quantity: ");
                    productQuantities.Add(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Product added successfully!\n");
                }

                if (choice == 2)
                {

                    Console.Write("\nEnter product to remove: ");
                    productNames.Remove(Console.ReadLine());
                    Console.Write("Remove how many? ");
                    productQuantities.Remove(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Update successful!\n");
                }


                if (choice == 3)
                {
                    Console.WriteLine("\nInventory Summary:");
                    Console.WriteLine($"");
                    Console.WriteLine($"Total product: {productNames.Count}");
                    Console.WriteLine($"Total Quantity: {productQuantities.Count}");
                    Console.WriteLine($"Average Quantity: {average:F2} \n");
                }
            }
        }
    }
}
