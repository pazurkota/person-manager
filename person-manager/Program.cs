// Person Manager project by pazurk0ta
// Licensed with MIT license

using person_manager.Controller;
using person_manager.Model;
using person_manager.Utility;

string filePath = "persons.json";
List<Person> persons;

try
{
    persons = JsonSerialization.Deserialize(filePath); // Get persons from .json file (deserialize)
}
catch (Exception exc)
{
    Console.WriteLine(exc);
    throw;
}

// Run program
Menu menu = new Menu(persons);
menu.Run();

// Save to .json file (serialize)
PersonManager.Save(filePath);