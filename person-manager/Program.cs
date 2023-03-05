// Person Manager project by pazurk0ta
// Licensed with MIT license

using person_manager.Controller;
using person_manager.Utility;

// File path (changing it is not advised)
string filePath = "persons.json";

// Run program
Menu menu = new Menu(PersonManager.Persons);
menu.Run();

// Save to .json file (serialize)
JsonSerialization.Serialize(PersonManager.Persons, filePath);