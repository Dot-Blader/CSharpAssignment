namespace AssignmentMain;

public static class Contacts
{
    private static FileServices _fileServices = new("Data", "contacts.json");

    private static List<Contact> contacts = [];

    public static void ShowAllContacts()
    {
        Console.Clear();
        Load();
        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName}");
            Console.WriteLine(contact.Email);
            Console.WriteLine(contact.Phone);
            Console.WriteLine($"{contact.Address} {contact.City} {contact.PostalCode}");
            Console.WriteLine("");
        }
        Console.ReadKey();
    }

    public static void CreateNewContact()
    {
        Console.Clear();
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Enter email: ");
        string email = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Enter phone number: ");
        string phone = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Enter home address: ");
        string address = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Enter city: ");
        string city = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Enter postal code: ");
        string postalCode = Console.ReadLine()!;
        Console.Clear();
        Contact contact = new Contact(firstName, lastName, email, phone, address, city, postalCode);
        Console.WriteLine("You are adding a contact with the following information: ");
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Phone Number: " + phone);
        Console.WriteLine("Home Address: " + address);
        Console.WriteLine("City: " + city);
        Console.WriteLine("Postal Code: " + postalCode);
        Console.ReadKey();
        Load();
        contacts.Add(contact);
        _fileServices.SaveContacts(contacts);
        Console.Clear();
    }
    private static void Load()
    {
        contacts = _fileServices.LoadContacts();
    }
}
