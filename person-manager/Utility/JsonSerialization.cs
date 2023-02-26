using System.Text.Json;
using person_manager.Model;

namespace person_manager.Utility;

public static class JsonSerialization
{
    // Serialize persons list to persons.json
    public static void Serialize(List<Person> persons, string filePath)
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string jsonText = JsonSerializer.Serialize(persons, options);
        File.WriteAllText(filePath, jsonText);
    }

    // Deserialize persons list from persons.json into the list
    public static List<Person> Deserialize(string filePath)
    {
        string jsonText = File.ReadAllText(filePath);
        List<Person> persons = JsonSerializer.Deserialize<List<Person>>(jsonText);
        return persons;
    }
}