using System.ComponentModel;

internal class Program
{
    static string login;
    static string password;
    static void Menu()
    {
        Console.WriteLine("                                                Магазин 'Спасите Помогите'");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("   Логин: " + login);
        Console.WriteLine("   Пароль:");
        Console.WriteLine("   Авторизоваться");
    }
    private static void Main(string[] args)
    {

        ConsoleKeyInfo key = Console.ReadKey();

        int p = 3;

        Menu();
        while (true)
        {

            //Console.Clear();
            Console.SetCursorPosition(0, p);
            Console.WriteLine("->");

            key = Console.ReadKey();
            Console.SetCursorPosition(0, p);
            Console.WriteLine("  ");
            if (key.Key == ConsoleKey.UpArrow)
            {
                p--;
            }

            if (key.Key == ConsoleKey.DownArrow)
            {
                p++;
            }

            if (p < 2)
            {
                p = 2;
            }

            if (p > 4)
            {
                p = 4;
            }
            Console.SetCursorPosition(0, p);
            Console.WriteLine("->");
            if (p == 2 && key.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(11, 2);
                Console.WriteLine("  ");

                Console.SetCursorPosition(11, 2);
                login = Console.ReadLine();

            }
            if (p == 3 && key.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(11, 3);
                Console.WriteLine("  ");
                List<char> v = new List<char>();
                Console.SetCursorPosition(11, 3);
                do
                {
                    key = Console.ReadKey(true);
                    Console.Write("*");
                    v.Add(key.KeyChar);
                    //ctrl + k + d
                } while (key.Key != ConsoleKey.Enter);
                password = "";
                for (int i = 0; i < v.Count; i++)
                {
                    password += v[i];
                }
            }
            if (p == 4 && key.Key == ConsoleKey.Enter)
            {



            }
        }
    }
}