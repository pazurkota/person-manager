using person_manager.Model;

namespace person_manager.Utility;

public class PersonManager
{
    public static void ShowPersonList()
    {
        string filePath = "persons.json";
        List<Person> persons = JsonSerialization.Deserialize(filePath);
        
        foreach (Person person in persons) Console.WriteLine(person);
        Console.WriteLine();
    }
}