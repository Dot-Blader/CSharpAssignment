
namespace AssignmentMain;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Id { get; set; }

    public Contact(string firstName, string lastName, string email, string phone, string address, string city, string postalCode)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Address = address;
        City = city;
        PostalCode = postalCode;
        Id = Guid.NewGuid().ToString();
    }
}
