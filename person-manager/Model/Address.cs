namespace person_manager.Model;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int HomeNumber { get; set; }
    public int? ApartmentNumber { get; set; }

    public override string ToString()
    {
        return $"{City}, {Street} st. ({HomeNumber}{(ApartmentNumber.HasValue ? $"/{ApartmentNumber}" : "")})";
    }
}