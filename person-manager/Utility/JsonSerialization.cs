using System.Text.Json;
using person_manager.Model;

namespace person_manager.Utility;

public static class JsonSerialization
{
    public static void Serialize(List<Person> persons, string filePath)
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string jsonText = JsonSerializer.Serialize(persons, options);
        File.WriteAllText(filePath, jsonText);
    }
}