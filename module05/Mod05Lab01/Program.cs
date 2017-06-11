using System;
using System.IO; // r&w files
using Newtonsoft.Json; // handles json
using System.Collections.Generic; // handles lists

class Mod05Lab01
{
    static void Main(string[] args)
    {
        string personStr = File.ReadAllText("people.json");
        var PersonList = new List<Person>();

        try {
            PersonList = JsonConvert.DeserializeObject<List<Person>>(personStr);
        } catch {
            Console.WriteLine("An error has occurred");
        }

        Console.WriteLine("First Name \t Last Name \t Mobile \t\t Email");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");

        foreach(Person p in PersonList) {
            Console.WriteLine(p.FirstName + "\t\t" + p.LastName + "\t\t" + 
                p.Mobile + "\t\t" + p.Email);
        }

    }
}
