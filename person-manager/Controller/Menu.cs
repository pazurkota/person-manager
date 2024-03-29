﻿using person_manager.Model;
using person_manager.Utility;
using static person_manager.Controller.Entry;

namespace person_manager.Controller;

public class Menu
{
    private List<Person> _persons;

    public Menu(List<Person> persons)
    {
        _persons = persons;
    }
    
    private void showMenu() // Method to show program options
    {
        string str = "Person Manager menu";

        str += "\n1. About";
        str += "\n2. Show full list";
        str += "\n3. Add new person";
        str += "\n4. Remove person (via ID)";
        str += "\n0. Exit program\n";

        Console.Write(str);
    }

    private void about() // "About" section
    {
        string str = "About:";

        str += "\nCreated by: pazurk0ta";
        str += "\nVersion: 1.0";
        str += "\nLicensed with MIT License";
        str += "\nRepo: https://github.com/pazurkota/person-manager.git\n";
        
        Console.WriteLine(str);
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
                    Console.Clear();
                    about();
                    break;
                case 2:
                    Console.Clear();
                    PersonManager.ShowPersonList();
                    break;
                case 3:
                    Console.Clear();
                    PersonManager.AddNewPerson();
                    break;
                case 4:
                    Console.Clear();
                    PersonManager.RemovePerson();
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