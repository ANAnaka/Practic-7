
using practic_4;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly data = new DateOnly(2022, 10, 13);

            ConsoleKeyInfo key = Console.ReadKey();

            do
            {
                Pdate(data, key);
            }
            while (key.Key == ConsoleKey.Escape);
        }

    
        static void Chislo(DateOnly data)
        {
            Console.WriteLine(data);
        }

        static void Menu1(DateOnly data, DateOnly data15, DateOnly data20)
        {
            Menu1(data, data15, data20);


            ConsoleKeyInfo key = Console.ReadKey();

            int posa = 1;

            Console.Clear();

            while (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {

                Console.WriteLine(data);

                Menu1(data, data15, data20);

                Console.SetCursorPosition(0, posa);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    posa--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    posa++;
                }

                if (posa == 3)
                {
                    posa = 1;
                }

                if (posa == 0)
                {
                    posa = 2;
                }

                Console.SetCursorPosition(0, posa);
                Console.WriteLine("->");

                Console.Clear();
            }
            while (key.Key == ConsoleKey.Enter)
            {
                if (data == data15 || data == data20)
                {
                    {
                        Zametka2(data, data15, data20, posa);
                        ConsoleKeyInfo key1 = Console.ReadKey();
                        if (key1.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            break;
                        }
                    }

                }
            }

            static void Menu1(DateOnly data, DateOnly data15, DateOnly data20)
            {
                List<Хочу_плакать> zametki = o();

                if (data == data15)
                {
                    Console.Write("   1. "); Console.WriteLine(zametki[0].microzaim);
                    Console.Write("   2. "); Console.WriteLine(zametki[1].microzaim);
                }

                if (data == data20)
                {
                    Console.Write("   1. "); Console.WriteLine(zametki[4].microzaim);
                    Console.Write("   2. "); Console.WriteLine(zametki[5].microzaim);
                }
            }

            static void Menu(DateOnly data, DateOnly data10, DateOnly data18)
            {
                Menu(data, data10, data18);
                Console.SetCursorPosition(0, 1);
                Console.Write("->");

                ConsoleKeyInfo key = Console.ReadKey();

                int position = 1;

                Console.Clear();

                while (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                {

                    Console.WriteLine(data);

                    Menu(data, data10, data18);

                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }

                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }

                    if (position != 1)
                    {
                        position = 1;
                    }

                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    Console.Clear();
                }
                while (key.Key == ConsoleKey.Enter)
                {

                    Zametka1(data, data10, data18);
                    ConsoleKeyInfo key1 = Console.ReadKey();
                    if (key1.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }

                }
            }

            static void Menu2(DateOnly date, DateOnly date10, DateOnly date18)
            {
                List<Хочу_плакать> zametki = o();

                if (date == date10)
                {
                    Console.Write("   1. "); Console.WriteLine(zametki[3].microzaim);
                }

                if (date == date18)
                {
                    Console.Write("   1. "); Console.WriteLine(zametki[2].microzaim);
                }
            }

            static List<Хочу_плакать> o()
            {
                Хочу_плакать zzam1 = new Хочу_плакать();
                zzam1.zametka = "Ждатц";

                Хочу_плакать zzam2 = new Хочу_плакать();
                zzam2.zametka = "Ходить пока ноги не отвалятся";

                Хочу_плакать zzam3 = new Хочу_плакать();
                zzam3.zametka = "Думать";

                Хочу_плакать zzam4 = new Хочу_плакать();
                zzam4.zametka = "Плакать";

                List<Хочу_плакать> zzametki = new List<Хочу_плакать>();
                zzametki.Add(zzam1);
                zzametki.Add(zzam2);
                zzametki.Add(zzam3);
                zzametki.Add(zzam4);
              
               
                return zzametki;
            }

            static void Zametka1(DateOnly date, DateOnly date10, DateOnly date18)
            {
                List<Хочу_плакать> zzametki = o();
                List<Хочу_плакать> zametki = o();

                if (date == date10)
                {
                    Console.WriteLine(zametki[3].microzaim);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(zzametki[3].zametka);
                    Console.WriteLine("Сделать " + date);
                }
                else if (date == date18)
                {
                    Console.WriteLine(zametki[2].microzaim);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(zzametki[2].zametka);
                    Console.WriteLine("Сделать " + date);
                }
            }

            static void Zametka2(DateOnly data, DateOnly data15, DateOnly data20, int position)
            {
                List<Хочу_плакать> zzametki = o();
                List<Хочу_плакать> zametki = o();

                if (data == data15)
                {
                    if (position == 1)
                    {
                        Console.WriteLine(zametki[0].microzaim);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine(zzametki[0].zametka);
                        Console.WriteLine("Сделать " + data);
                    }

                    if (position == 2)
                    {
                        Console.WriteLine(zametki[1].microzaim);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine(zzametki[1].zametka);
                        Console.WriteLine("Сделать " + data);
                    }
                }
                else if (data == data20)
                {
                    if (position == 1)
                    {
                        Console.WriteLine(zametki[2].microzaim);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine(zzametki[2].zametka);
                        Console.WriteLine("Сделать " + data);
                    }

                    if (position == 2)
                    {
                        Console.WriteLine(zametki[3].microzaim);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine(zzametki[3].zametka);
                        Console.WriteLine("Сделать " + data);
                    }
                }
            }

            static List<Хочу_плакать> op()
            {
                Хочу_плакать zametka0 = new Хочу_плакать();
                zametka0.microzaim = "Дождаться Сашу из полиции";

                Хочу_плакать zametka1 = new Хочу_плакать();
                zametka1.microzaim = "Съездить на садовод";

                Хочу_плакать zametka2 = new Хочу_плакать();
                zametka2.microzaim = "Весь день делать C#";

                Хочу_плакать zametka3 = new Хочу_плакать();
                zametka3.microzaim = "Плакать весь вечер из-за C#";

                List<Хочу_плакать> zametki = new List<Хочу_плакать>();
                zametki.Add(zametka0);
                zametki.Add(zametka1);
                zametki.Add(zametka2);
                zametki.Add(zametka3);

                return zametki;
            }
        }
    }
}