// Person Manager project by pazurk0ta
// Licensed with MIT license

using person_manager.Model;
using person_manager.Utility;

// Example person
Person example = new Person() // Initializing new Person
{
    ID = 1,
    Name = "William",
    Surname = "Blazkowicz",
    Age = 49,
    PhoneNumber = 19911508,
    
    Address = new Address() // The "Address" is an other class, so we need to initialize like this 
    {
        City = "Berlin",
        Street = "Nauener Platz",
        HomeNumber = 42,
        ApartmentNumber = null // The ApartmentNumber can be null
    }
};

/* Json serialization example
 * string filePath = "persons.json";
 * List<Person> persons = new List<Person>() { example };
 * 
 * JsonSerialization.Serialize(persons, filePath);
 */

/* Json deserialization example
* string filePath = "persons.json";
* List<Person> persons = JsonSerialization.Deserialize(filePath);
* 
* foreach (Person person in persons) Console.WriteLine(person.ToString());
*/