using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
        }
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
                outputFile.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            entry.FromFileString(line);
            _entries.Add(entry);
        }
    }
}