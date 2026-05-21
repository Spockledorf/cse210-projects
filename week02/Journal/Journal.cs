// Responsibility: Stores and manages a collection of journal entries.
// Behavior: Adds entries, displays entries, saves entries to a file, loads entries from a file.
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
        if (_entries.Count() == 0)
        {
            Console.WriteLine("No entires found!");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
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
        _entries.Clear(); // Removes all entries to make a clean list.
        if (!File.Exists(filename))
        {
            Console.WriteLine();
            Console.WriteLine("File does not exist.");
            return;
        }
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
    public int GetTotalCharCount()
    {
        int charCount = 0;
        foreach (Entry entry in _entries)
        {
            int stringLength = entry._entryText.Length;
            charCount += stringLength;
        }
        return charCount;
    }
    public int GetEntryCount()
    {
        return _entries.Count;
    }
}
