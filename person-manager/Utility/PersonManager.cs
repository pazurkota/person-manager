using person_manager.Model;
using person_manager.Controller;

namespace person_manager.Utility;

public class PersonManager
{
    public List<Person> Persons;

    public static void ShowPersonList()
    {
        string filePath = "persons.json";
        List<Person> persons = JsonSerialization.Deserialize(filePath);
        
        foreach (Person person in persons) Console.WriteLine(person);
        Console.WriteLine();
    }

    public static Person AddNewPerson()
    {
        Person person = Entry.GetPersonInfo();
        return person;
    }
}