using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
public List<Entry> _entries;

public void AddEntry(Entry newEntry)
{
    _entries.Add(newEntry);
}

public void DisplayAll()
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No Entries found.");
    }
    else 
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}

public void SaveToFile(string file)
{
    try
    {
        using(StreamWriter writer = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}| {entry._promptText}| {entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {file}.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving to file: {ex.Message}");
    }
}

public void LoadFromFile(string file)
{
    try 
    {
        _entries.Clear(); // Clearing current entries before lodaing new entries
        using(StreamReader reader = new StreamReader(file))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                var parts = line.Split("|");
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Journal loaded from {file}.");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Error lodaing from file: {ex.Message}");
    }
}
}