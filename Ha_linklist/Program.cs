// Khai Ha
// IT113
// NOTES: The whole node concepts is pretty similar to magic the gathering stacks. First in last out and to do something you need to insert something
// similar to a tempt node to hold value.

namespace Ha_linklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList MyList = new(); // Call to class, and create a new instance
            int choice; // Variable for choices

            do
            {
                Console.WriteLine("Menu:"); // Menu... inside of the while loop
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. Search for item");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine()); // Converts the input into an int so we can use it with the switch

                

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name: ");
                        MyList.Add(Console.ReadLine()); // captures input and calls add method from LinkList
                        break;

                    case 2:
                        Console.Write("Enter the name to remove: ");
                        bool removed = MyList.Remove(item: Console.ReadLine()); // captures input and invoke Remove method
                        Console.WriteLine(removed ? "Item removed." : "Item not found.");
                        break;

                    case 3:
                        Console.Write("Enter the name to search: ");
                        bool found = MyList.Search(Console.ReadLine()); // captures input and activate the Search Method
                        Console.WriteLine(found ? "Item found." : "Item not found.");
                        break;

                    case 4:
                        MyList.PrintAll(); // Innitiates the PrintAll method
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");  // Breaks loop to exit program
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again."); // Error response if inserted value is beyond specified options
                        break;
                }

            } while (choice != 5);
        }
    }
}