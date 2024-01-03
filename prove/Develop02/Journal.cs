using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string _fileName;

    public Person person;
    
    public void DisplayJornal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
        }
    }

    public void AddEntry(Entry entry )
    {
        entry.Write();
        _entries.Add(entry);
    }

    public void SaveToFile( string _fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} > {entry._prompt} > {entry._response}");
            }
        }
    }

   
    public void LoadToFile(string _fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach(string line in lines)
        {
            string[] files= line.Split(">");
            Entry entry =new Entry();
            entry._date = files[0];
            entry._response = files[1];
            entry._prompt=files[2];
            _entries.Add(entry);

        }
    }

}