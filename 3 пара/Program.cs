/*1.Сложить 2 числа
2.Вычесть первое из второго
3. Перемножить два числа
4. Разделить первое на второе
5. Возвести в степень N первое число
6. Найти квадратный корень из числа
7. Найти 1 процент от числа
8. Найти факториал из числа
9. Выйти из программы*/

using static System.Net.Mime.MediaTypeNames;


    Console.WriteLine("Выберите какую операцию вы хотите выполнить: ");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить 2 числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    int Comand = Convert.ToInt32(Console.ReadLine());
    do
    {
        if (Comand == 1)
        {
            Console.WriteLine(" Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + b);
        }

        if (Comand == 2)
        {
            Console.WriteLine(" Введите первое число");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите второе число");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(d - c);
        }
        if (Comand == 3)
        {
            Console.WriteLine(" Введите первое число");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите второе число");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(e * f);

        }
        if (Comand == 4)
        {
            Console.WriteLine(" Введите первое число");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите второе число");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(g / i);

        }
        if (Comand == 5)
        {
            Console.WriteLine(" Введите число");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите степень числа");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(k, l));
        }
        if (Comand == 6)
        {
            Console.WriteLine(" Введите число");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(m));
        }
        if (Comand == 7)
        {
            Console.WriteLine(" Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((n / 100) * 1);

        }
        if (Comand == 8)
        {
            Console.WriteLine(" Введите число");

            int w = 1;

            for (int o = Convert.ToInt32(Console.ReadLine()); o > 0; o--)
            {

                w = w * o;

            }

            Console.WriteLine(w);
        }
        if (Comand == 9)
        {
            Environment.Exit(0);

        }
    } while (Comand <= 9);
