public class Person
{
    public string _firstName;
    public string _lastName;

    public void Fullname()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }

    public void Display()
    {
        Console.Write("Please enter your first name: ");
        _firstName=Console.ReadLine();

        Console.Write("Please enter your last name: ");
        _lastName=Console.ReadLine();

        Console.WriteLine($"Welcome {_firstName} {_lastName}");
    }
}