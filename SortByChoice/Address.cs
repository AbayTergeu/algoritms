namespace SortByChoice;

public record class Address
{
    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }

    public string Street { get; set; }
    public string City { get; set; }
}