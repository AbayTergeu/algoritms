namespace SortByChoice;

public class DataSource
{
    public static List<Contact> GetContacts() 
    {
        return new List<Contact>() 
        {
            new ("John", Department.Admin, "+1234", new ("Street 1","City 1")),
            new ("Jane", Department.CustomerCare, "+2341", new("Street 2", "City 2")),
            new ("Mike", Department.Operations, "+3421", new("Street 3", "City 3"))
        };
    }
}