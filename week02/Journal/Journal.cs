using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.IO;
public class Journal
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        string filename = "";
        Console.WriteLine("What is the filename?");
        filename = Console.ReadLine();
        using (StreamWriter outpuFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outpuFile.WriteLine($"{e._date} - {e._promptText}");
                outpuFile.WriteLine($"{e._entryText}");
                outpuFile.WriteLine("\n");

            }
        }

    }
    
// GOT THIS FUNCTION FROM CHAT GPT
// I didn't know how to do it and the project itsefl was draining my energies already 
    public void LoadFromFile()
    {
            Console.Write("What is the filename? ");
    string filename = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(filename))
    {
        Console.WriteLine("Filename cannot be empty.");
        return;
    }

    if (!File.Exists(filename))
    {
        Console.WriteLine($"File '{filename}' not found.");
        return;
    }

    string[] lines = File.ReadAllLines(filename);
    _entries.Clear(); // Optional: prevents duplication if loading again

    for (int i = 0; i < lines.Length; i++)
    {
        string line = lines[i].Trim();

        // Skip empty lines
        if (string.IsNullOrWhiteSpace(line))
            continue;

        // First non-empty line contains date and prompt
        if (line.Contains(" - "))
        {
            Entry entry = new Entry();

            // Split date and prompt
            string[] parts = line.Split(" - ", 2);
            entry._date = parts[0].Trim();
            entry._promptText = parts[1].Trim();

            // Next non-empty line is the entry text
            i++;
            while (i < lines.Length && string.IsNullOrWhiteSpace(lines[i]))
                i++;

            if (i < lines.Length)
                entry._entryText = lines[i].Trim();

            _entries.Add(entry);
        }
    }

    Console.WriteLine($"Loaded {_entries.Count} entries from '{filename}'.");

    }
}