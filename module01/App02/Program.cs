using System;

class App02
{
    public enum days {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
    static void Main(string[] args)
    {
        string[] strDays = Enum.GetNames(typeof(days));

        foreach(string day in strDays) {
            Console.WriteLine(day);
        }
    }
}
