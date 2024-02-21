using System;

class Program
{
    static void Main(string[] args)
    {
        // Lectures Event Details
        string lTitle = "Light From on High Illuminates Science and Religion.";
        string lDesc = "Annual Summerhays Lecture.";
        string lDate = "Thursday, October 12th 2017";
        string lTime = "7pm";
        string name = "Dr. Allan Ashton";
        int capacity = 3000;
        string lStreet = "2254 BYU Conference Center";
        string lCity = "Salt Lake City";
        string lState = "Utah";
        string lCountry = "United States.";

        // Receptions Event Details
        string rTitle = "The Union of William Osiakwan and Chloe Sanders";
        string rDesc = "Wedding Reception";
        string rDate = "9th October 2029";
        string rTime = "10am - 1pm";
        string email = "willichloe@gmail.com";
        string rStreet = "100 Hinckley Way, Belmont, MA02478";
        string rCity = "Boston";
        string rState = "Massachusetts";
        string rCountry = "United States";

        // Outdoor Event Details
        string oTitle = "Remarkable Growth of the Church in West Africa";
        string oDesc = "Elder Bednar Dedicates New Missionary Training Center in Ghana";
        string oDate = "24th October 2017";
        string oTime = "10am - 2pm";
        string weather = "A normal clear and a sunny weather.";
        string oStreet = "57 Independece Avenue";
        string oCity = "Accra";
        string oState = "Greater Accra";
        string oCountry = "Ghana";

        // Instance 3 instances of the Address class
        Address lAddress = new Address(lStreet, lCity, lState, lCountry);
        Address rAddress = new Address(rStreet, rCity, rState, rCountry);
        Address oAddress = new Address(oStreet, oCity, oState, oCountry);

        // Instantiate Lectures, Receptions and OutdoorGathering class
        Lectures lecture = new Lectures(lTitle, lDesc, lAddress, lDate, lTime, name, capacity);
        Receptions reception = new Receptions(rTitle, rDesc, rAddress, rDate, rTime, email);
        OutdoorGathering outdoor = new OutdoorGathering(oTitle, oDesc, oAddress, oDate, oTime, weather);

        // Display Events
        lecture.DisplayEvent();
        Console.WriteLine("\n");
        reception.DisplayEvent();
        Console.WriteLine("\n");
        outdoor.DisplayEvent();
    }
}