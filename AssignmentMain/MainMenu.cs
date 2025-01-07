using AssignmentMain;

public class MainMenu
{
    public void Main()
    {
        Console.Clear();
        Console.WriteLine("Type the number of the option you want to select:");
        Console.WriteLine("1. Show all contacts.");
        Console.WriteLine("2. Create new contact.");
        string input = Console.ReadLine()!;
        if (input == "1")
        {
            Contacts.ShowAllContacts();
        }
        else if (input == "2")
        {
            Contacts.CreateNewContact();
        }
    }
}