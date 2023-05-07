using person_manager.Model;
using person_manager.Controller;
using Newtonsoft.Json;

namespace person_manager.Utility;

public class PersonManager
{
    public static List<Person> Persons = JsonSerialization.Deserialize("persons.json");

    public static void ShowPersonList()
    {
        string filePath = "persons.json";
        List<Person> persons = JsonSerialization.Deserialize(filePath);
        
        foreach (Person person in persons) Console.WriteLine(person);
        Console.WriteLine();
    }

    public static void AddNewPerson()
    {
        Person person = Entry.GetPersonInfo();
        Persons.Add(person);
    }

    public static void RemovePerson()
    {
        // @TODO
    }
}