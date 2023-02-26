namespace person_manager.Model;

public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int PhoneNumber { get; set; }
    public Address Address { get; set; }

    public override string ToString()
    {
        return $"({ID}) {Name} {Surname}, Age: {Age}, Phone Number: {PhoneNumber}\nAddress: {Address}";
    }
}