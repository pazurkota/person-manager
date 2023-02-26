// Person Manager project by pazurk0ta
// Licensed with MIT license
// Version 0.1

using person_manager.Model;

// Example:
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


Console.WriteLine(example.ToString());