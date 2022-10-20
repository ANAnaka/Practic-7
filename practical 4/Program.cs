using practical_4;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime data = new DateTime();
        data = DateTime.Now;

        while (true)
        {
            Console.WriteLine(data.ToShortDateString());
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.RightArrow)
            {
                data = data.AddDays(+1); ;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                data = data.AddDays(-1); ;
            }
            Console.Clear();

        }
        Хочется_плакать microzaim = new Хочется_плакать();
        microzaim.date = new DateTime(2022, 10, 20);
    }
}