namespace SortByChoice;

public record class Contact
{
    public Contact(string name, Department department, string phone, Address address)
    {
        Name = name;
        Department = department;
        Phone = phone;
        Address = address;
    }

    public string Name { get; set; }
    public Department Department { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }
}