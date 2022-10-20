int position = 1;
while (true)
{
    Console.SetCursorPosition(0, position);
    Console.WriteLine("-->");
    ConsoleKeyInfo key = Console.ReadKey();

    Console.SetCursorPosition(0, 1);
    Console.WriteLine("-->");

    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;


    }

    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    Console.Clear();
    Console.WriteLine("Выберите ваш любимый цвет");
    Console.WriteLine("   1. Красный");
    Console.WriteLine("   2. Синий");
    Console.WriteLine("   3. Зеленый");
    Console.WriteLine("   4. Белый");
    Console.SetCursorPosition(0, position);
    Console.WriteLine("-->");

    int[] a = new[] { 1, 2, 3, 4 };
        Console.Beep(a[3],100);

    if(position == 2)
        {
        Console.WriteLine("Eto sinii");
    }
}