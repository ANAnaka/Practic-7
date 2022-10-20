namespace _5_лекция._Методы
{
    internal class Program
    {
        static int Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int result = Sum(x, y); 
            Console.WriteLine(result);
            Math.Pow(x, y);
        }

        static int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }

    }
}