class Program
{
    static void Main()
    {
        int hour = DateTime.Now.Hour; //hent den virkelige tiden (0-23)
        Console.Write("Hva heter du? "); //spør om navn
        string name = Console.ReadLine(); //skriv navn

        if (hour < 12)
        {
            Console.WriteLine("God morgen " + (name) + "!"); //om klokka er under 12, print ut "god morgen /navn/!" i terminalen
        }
        else if (hour < 17)
        {
            Console.WriteLine("God dag " + (name) + "!"); //om klokka er mellom 12 og 17, print ut "god dag /navn/!" i terminalen
        }
        else
        {
            Console.WriteLine("God kveld " + (name) + "!"); //om klokka er etter 17, print ut "god kveld /navn/!" i terminalen
        }
    }
}
