using person_manager.Model;
using static person_manager.Controller.Entry;

namespace person_manager.Controller;

public class Menu
{
    private List<Person> _persons;

    public Menu(List<Person> persons)
    {
        _persons = persons;
    }
    
    private void showMenu()
    {
        string str = "Person Manager menu";

        str += "\n1. About";
        str += "\n2. Show full list";
        str += "\n3. Add new person";
        str += "\n4. Remove person (via ID)";
        str += "\n0. Exit program\n";

        Console.Write(str);
    }

    public void Run() // Runs program
    {
        int choice = 0;

        do
        {
            showMenu();
            choice = GetInput(" > ", 4);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("This option wasn't implemented yet...");
                    break;
                case 2:
                    Console.WriteLine("This option wasn't implemented yet...");
                    break;
                case 3:
                    Console.WriteLine("This option wasn't implemented yet...");
                    break;
                case 4:
                    Console.WriteLine("This option wasn't implemented yet...");
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    break;
            }
            
        } while (choice != 0);
    }
}