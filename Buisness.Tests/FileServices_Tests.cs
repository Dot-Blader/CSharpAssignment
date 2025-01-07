using AssignmentMain;
using AssignmentMain.Services;

namespace Assignment.Tests;

public class FileServices_Tests
{
    [Fact]
    public void SaveContacts_ShouldBeTrue()
    {
        var service = new FileServices();
        var contacts = service.LoadContacts();

        Assert.True(service.SaveContacts(contacts));
    }

    [Fact]
    public void LoadContacts_ShouldReturnList()
    {
        var service = new FileServices();
        var contacts = service.LoadContacts();

        Assert.IsType<List<Contact>>(contacts);
    }
}
