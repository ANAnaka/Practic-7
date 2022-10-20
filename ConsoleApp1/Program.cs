using System;
using System.Reflection.Metadata.Ecma335;

namespace pianino_end
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aktava1();
        }
        static void Aktava1()
        {
            Console.WriteLine("актава 1 - F1, актава 2 - F2");
            while (true)
            {
                Slovo();
                Console.Clear();
            }
        }

        static void Slovo()
        {
            ConsoleKeyInfo nota = Console.ReadKey();
            if (nota.Key == ConsoleKey.F1)
            {
                OneOktava();
            }
            if (nota.Key == ConsoleKey.F2)
            {
                TwoOktava();
            }
        }


        static void OneSOktava()
        {
            ConsoleKeyInfo nota = Console.ReadKey();
            if (nota.Key == ConsoleKey.F1)
            {

                OneOktava();
            }
            if (nota.Key == ConsoleKey.F2)
            {
                TwoOktava();
            }
        }
        static int[] oktava2()
        {
            int[] nota2 = new int[] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124 };
            return nota2;
        }
        static void OneOktava()
        {
            ConsoleKeyInfo nota = Console.ReadKey();
            if (nota.Key == ConsoleKey.A)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[0], 200);
            }
            if (nota.Key == ConsoleKey.W)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[1], 200);
            }
            if (nota.Key == ConsoleKey.S)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[3], 200);
            }
            if (nota.Key == ConsoleKey.E)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[3], 200);
            }
            if (nota.Key == ConsoleKey.D)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[4], 200);
            }
            if (nota.Key == ConsoleKey.F)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[5], 200);
            }
            if (nota.Key == ConsoleKey.T)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[6], 200);
            }
            if (nota.Key == ConsoleKey.G)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[7], 200);
            }
            if (nota.Key == ConsoleKey.Y)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[8], 200);
            }
            if (nota.Key == ConsoleKey.H)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[9], 200);
            }
            if (nota.Key == ConsoleKey.U)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[10], 200);
            }
            if (nota.Key == ConsoleKey.J)
            {
                int[] nota2 = oktava2();
                Console.Beep(nota2[11], 200);
            }
        }
    
        static void TwoOktava()
        {
            ConsoleKeyInfo nota = Console.ReadKey();
            if (nota.Key == ConsoleKey.A)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[0], 200);
            }
            if (nota.Key == ConsoleKey.W)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[1], 200);
            }
            if (nota.Key == ConsoleKey.S)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[3], 200);
            }
            if (nota.Key == ConsoleKey.E)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[3], 200);
            }
            if (nota.Key == ConsoleKey.D)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[4], 200);
            }
            if (nota.Key == ConsoleKey.F)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[5], 200);
            }
            if (nota.Key == ConsoleKey.T)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[6], 200);
            }
            if (nota.Key == ConsoleKey.G)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[7], 200);
            }
            if (nota.Key == ConsoleKey.Y)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[8], 200);
            }
            if (nota.Key == ConsoleKey.H)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[9], 200);
            }
            if (nota.Key == ConsoleKey.U)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[10], 200);
            }
            if (nota.Key == ConsoleKey.J)
            {
                int[] nota3 = oktava3();
                Console.Beep(nota3[11], 200);
            }
            static int[] oktava3()
            {
                int[] nota3 = new int[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
                return nota3;
            }

        }
    }
}
