using System.IO;

public class Journal
{
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

    public void SaveToFile(string file)
{
    using (StreamWriter outputFile = new StreamWriter(file))
    {
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}~|~{entry._time}~|~{entry._promptText}~|~{entry._entryText}");
        }
    }
}
    public void LoadFromFile(string file)
{
    _entries.Clear();
    string[] lines = File.ReadAllLines(file);

    foreach (string line in lines)
    {
        string[] parts = line.Split("~|~");
        
        Entry loadedEntry = new Entry();
        loadedEntry._date = parts[0];
        loadedEntry._time = parts[1];
        loadedEntry._promptText = parts[2];
        loadedEntry._entryText = parts[3];
        
        _entries.Add(loadedEntry);
    }
}
}