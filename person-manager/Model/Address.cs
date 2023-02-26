namespace person_manager.Model;

public class Address
{
    public string City;
    public string Street;
    public int HomeNumber;
    public int? ApartmentNumber; 

    public override string ToString()
    {
        return $"{City}, {Street} st. ({HomeNumber}{(ApartmentNumber.HasValue ? $"/{ApartmentNumber}" : "")})";
    }
}