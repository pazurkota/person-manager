using person_manager.Model;
using person_manager.Controller;

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
        File.WriteAllText("persons.json", null);
        int id = Entry.GetID();

        var personToRemove = from person in Persons
            where person.ID == id
            select person;

        Persons.RemoveAll(personToRemove => personToRemove.ID == id);
        JsonSerialization.Serialize(Persons, "persons.json");
    }
}