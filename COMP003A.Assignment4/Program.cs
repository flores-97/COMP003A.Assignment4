/*
 Author: Victor Flores
Course: COMP-003A
Faculty: Jonathon Cruz
Purpose: Inventory management application with a minimum of 10 elements in the collection.
*/
namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)

            
            
        {
            Console.WriteLine("Welcome to the Inventory Management System!");
            int done;
            int choice;
            while (true)
            {
                Console.WriteLine("Choose data storage type: ");
                Console.WriteLine("1. Array\n2. String\n");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice >= 3)
                {
                    Console.WriteLine("Invalid entry. Select '1' or '2'.");
                }

                if (choice == 1)
                { //enteries for array below
                    Menu();

                    Console.Write("Enter '4' when done: ");
                    done = int.Parse(Console.ReadLine());

                    if (choice == done) break;
                }

                if (choice == 2)
                {//enteries for list
                    Menu();

                    Console.Write("Enter '4' when done: ");
                    done = int.Parse(Console.ReadLine());

                    if (choice == done) break;
                }

            }
          static void Menu()
            {
                    Console.WriteLine("Inventory Management System Menu: ");
                    Console.WriteLine("1. Add a Product");
                    Console.WriteLine("2. Update Product Quantity");
                    Console.WriteLine("3. View Inventory Summary");
                    Console.WriteLine("4. Exit");
            }
        }
    }
}
