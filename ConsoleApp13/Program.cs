namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine(" выберите октаву F1,F2,F3,F4");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F1)
            {
                oneOctava();
            }
            else if (key.Key == ConsoleKey.F2)
            {
                twoOctava();
            }
            else if (key.Key == ConsoleKey.F3)
            {
                threeOctava();
               
            }
            else if (key.Key == ConsoleKey.F4)
            {
                fourOctava();
            }
        }
        static void oneOctava()
        {
            int[] one = new[] { 33, 35, 37, 39, 41, 44, 46, 49, 52, 55, 58, 62 };
            Sound(one);
        }
        static void Sound(int[] alloctaves)
        {
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.Enter)
            {
                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(440, 300);                         
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.C:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(415, 300);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.L:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.M:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.Enter:
                        Menu();
                        break;
                }
            }
        }
        static void twoOctava()
        {
            int[] two = new[] { 65, 69, 74, 78, 82, 87, 93, 98, 104, 110, 117, 123 };
            sound(two);
        }
        static void sound(int[] alloctaves)
        {
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.Enter)
            {
                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.C:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(415, 300);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.L:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.M:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;                  

                }
            }
        }
        static void threeOctava()
        {
            int[] tree = new[] { 131, 139, 148, 156, 165, 175, 185, 196, 207, 220, 233, 245 };
            SOUND(tree);
        }
        static void SOUND (int[] alloctaves)
        {
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.Enter)
            {
                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.C:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(415, 300);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.L:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.M:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                }
            }   
        }
        static void fourOctava()
        {
            int[] four = new[] { 262, 277, 293, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            SoUnD (four);
        }
        static void SoUnD (int[] alloctaves)
        {
            ConsoleKeyInfo k = Console.ReadKey();
            while (k.Key != ConsoleKey.Enter)
            {
                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.C:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(440, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(415, 300);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.L:
                        Console.Beep(330, 300);
                        Console.Clear();
                        break;
                    case ConsoleKey.M:
                        Console.Beep(415, 300);
                        Console.Clear();
                        break;
                }
            }
        }


    }
}