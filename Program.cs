class Program
{
    static void Main()
    {
        int hour = DateTime.Now.Hour; // Get the current hour (0-23)

        if (hour < 12)
        {
            Console.WriteLine("God morgen!");
        }
        else if (hour < 17)
        {
            Console.WriteLine("God dag!");
        }
        else
        {
            Console.WriteLine("God kveld!");
        }
    }
}
