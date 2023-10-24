public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"{_date}  {_prompt}  {_response}");
    }

    // DEFUALT CONSTRUCTOR
    // CONSTRUCTOR(date, prompt, response)
    //      _date = date
    //      ...
    public void Write()
    {
        _date = DateTime.Now.ToShortDateString();
        Prompt myPrompt = new Prompt();
        _prompt = myPrompt.Prompts();
        // Display the prompt
        Console.WriteLine(_prompt);
        // Get response
        _response =Console.ReadLine();
    }


    // DISPLAY
    public void Display()
    {
        Console.WriteLine($"{_date}  {_prompt} {_response}" );
    }
    // PUT _date
    // PUT _prompt
    // PUT _response

}