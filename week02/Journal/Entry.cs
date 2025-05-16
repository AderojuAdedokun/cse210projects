using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; // Exceeding requirements: add a mood tag

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }

    // For saving/loading
    public string ToFileString()
    {
        // Use ~|~ as a separator to avoid conflicts
        return $"{_date}~|~{_promptText}~|~{_entryText}~|~{_mood}";
    }

    public void FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length >= 4)
        {
            _date = parts[0];
            _promptText = parts[1];
            _entryText = parts[2];
            _mood = parts[3];
        }
    }
}