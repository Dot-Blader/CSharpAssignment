using System.Diagnostics;
using System.Text.Json;

namespace AssignmentMain.Services;

public class FileServices
{
    private readonly string _directoryPath;
    private readonly string _filePath;
    private readonly JsonSerializerOptions _options;

    public FileServices(string directoryPath = "Data", string fileName = "contacts.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
        _options = new JsonSerializerOptions { WriteIndented = true };
    }

    public bool SaveContacts(List<Contact> contacts)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            var json = JsonSerializer.Serialize(contacts, _options);
            File.WriteAllText(_filePath, json);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
    public List<Contact> LoadContacts()
    {
        try
        {
            if (!File.Exists(_filePath))
            {
                return [];
            }

            var json = File.ReadAllText(_filePath);
            var list = JsonSerializer.Deserialize<List<Contact>>(json, _options);
            return list ?? [];
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return [];
        }
    }
}
