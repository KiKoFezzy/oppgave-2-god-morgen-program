class Program
{
    static void Main()
    {
        int hour = DateTime.Now.Hour; //hent den virkelige tiden (0-23)

        if (hour < 12)
        {
            Console.WriteLine("God morgen!"); //om klokka er under 12, print ut "god morgen" i terminalen
        }
        else if (hour < 17)
        {
            Console.WriteLine("God dag!"); //om klokka er mellom 12 og 17, print ut "god dag" i terminalen
        }
        else
        {
            Console.WriteLine("God kveld!"); //om klokka er etter 17, print ut "god kveld" i terminalen
        }
    }
}
