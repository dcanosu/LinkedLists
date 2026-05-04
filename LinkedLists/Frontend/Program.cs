using System.ComponentModel.Design;
using Backend;

var List = new SinglyLinkedList<string>();
var option = string.Empty;
var value = string.Empty;
do
{
        option = Menu();
        switch (option)
        {
            case "1":
                Console.Write("Enter a value: ");
                value = Console.ReadLine() ?? string.Empty;
                List.InsertAtBeginning(value);
                break;
            case "2":
                Console.Write("Enter a value: ");
                value = Console.ReadLine() ?? string.Empty;
                List.InsertAtEnding(value);
                break;
            case "3":
                Console.Write("Enter a value to search for: ");
                value = Console.ReadLine() ?? string.Empty;
                var exists = List.Contains(value);
                if (exists)
                {
                    Console.WriteLine($"Value '{value}' found in the list.");
                }
                else
                {
                    Console.WriteLine($"Value '{value}' not found in the list.");
                }
                break;
            case "4":
                Console.Write("Enter a value to remove: ");
                value = Console.ReadLine() ?? string.Empty;
                List.Remove(value);
                break;
            case "5":
                List.Reverse();
                break;
            case "6":
                Console.WriteLine(List);
                break;
            case "0":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    } while (option != "0");

string Menu()
{
    Console.WriteLine("1. Insert at the beginning");
    Console.WriteLine("2. Insert at the ending");
    Console.WriteLine("3. Search for a value");
    Console.WriteLine("4. Remove a value");
    Console.WriteLine("5. Reverse the list");
    Console.WriteLine("6. Order the list");
    Console.WriteLine("7. Insert ordered");
    Console.WriteLine("8. Show the list");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Enter a option: ");
    return Console.ReadLine() ?? string.Empty;
}
