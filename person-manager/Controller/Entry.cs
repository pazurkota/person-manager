using person_manager.Model;

namespace person_manager.Controller;

public static class Entry
{
    public static int GetInput(string str, int maxValue, int minValue = 0)
    {
        int? number = null;

        do
        {
            try
            {
                string? s;

                do
                {
                    Console.Write(str);
                    s = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(s));

                number = int.Parse(s);
                if (number < minValue || number > maxValue) throw new Exception("Invalid number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        } while (!number.HasValue);

        return number.Value;
    }

    public static Person GetPersonInfo()
    {
        Person person = new Person();

        // Get Person Info:
        Console.Write("Enter person ID > ");
        person.ID = int.Parse(Console.ReadLine() ?? throw new Exception("ID Cannot be null!"));
        
        Console.Write("Enter person name > ");
        person.Name = Console.ReadLine() ?? string.Empty;
        
        Console.Write("Enter person surname > ");
        person.Surname = Console.ReadLine() ?? string.Empty;
        
        Console.Write("Enter person age > ");
        person.Age = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
        
        Console.Write("Enter person phone number > ");
        person.PhoneNumber = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
        
        
        // Get Person Address
        Address address = new Address();
        
        Console.Write("Enter person city > ");
        address.City = Console.ReadLine() ?? string.Empty;
        
        Console.Write("Enter person street > ");
        address.Street = Console.ReadLine() ?? string.Empty;
        
        Console.Write("Enter person home number > ");
        address.HomeNumber = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
        
        Console.Write("Enter person apartment number > ");
        address.ApartmentNumber = Convert.ToInt32(Console.ReadLine());
        
        
        // Return
        person.Address = address;
        Console.WriteLine();
        return person;
    }

    public static int GetID()
    {
        Console.Write("Enter persons ID > ");
        int id = Convert.ToInt32(Console.ReadLine() ?? throw new ArgumentException("ID cannot be null!"));
        
        return id;
    }
}