// Responsibility: Keeps track of the Journal entries in a list.
// Behavior:
using System.IO; 

public class Journal
{
    public List<Entry> _entries = [];
    public void AddEntry(Entry newEntry)
    {
        // Add entry to journal
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        // Display all journal entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        // Save journal to file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        // Load journal from file
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string dateText = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry lineEntry = new Entry(dateText, prompt, response);
            _entries.Add(lineEntry);            
        }
    }


}
