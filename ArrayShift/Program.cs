using System;

namespace ArrayShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int ArraySize = 10;

            int Array2DX = 10;
            int Array2DY = 10;
            int RangeRandom = 10;

            while (true)
            {
                Console.WriteLine("Выбирите с каким массивом работать\n1 - одномерный\n2 - двумерный\nq - выйти");
                string choose = Console.ReadLine();

                if(choose == "Q" || choose == "q")
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&pp=ygUIcmlja3JvbGw%3D");
                    return;
                }

                Console.Clear();
                Console.SetCursorPosition(0, 1);

                if (int.TryParse(choose, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Array array = new Array(ArraySize, RangeRandom);
                            array.Start();
                            break;

                        case 2:
                            Array2D array2d = new Array2D(Array2DX, Array2DY, RangeRandom);
                            array2d.Start();
                            break;

                        default:
                            Console.WriteLine("Пошла нахуй шлюха");
                            Console.Write("\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ну ты долбаеб нет?!?!?!");
                    Console.Write("\n");
                }
            }


        }
    }
}
