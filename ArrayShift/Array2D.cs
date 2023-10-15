using System;

namespace ArrayShift
{
    internal class Array2D
    {
        private int[,] array;

        public Array2D(int sizeX, int sizeY, int rangeRandom)
        {
            array = new int[sizeX, sizeY];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(rangeRandom);
                }
            }
        }

        public void ShowArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShiftUp()
        {
            int[] temp = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                temp[j] = array[0, j];

            }

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i + 1, j];
                }
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[array.GetLength(0) - 1, j] = temp[j];
            }

        }

        public void ShiftDown()
        {
            int[] temp = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                temp[j] = array[array.GetLength(0) - 1, j];

            }

            for (int i = array.GetLength(0) - 1; i > 0; i--)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i - 1, j];
                }
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[0, j] = temp[j];
            }
        }

        public void ShiftLeft()
        {
            int[] temp = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp[i] = array[i, 0];

            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    array[i, j] = array[i, j + 1];
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, array.GetLength(1) - 1] = temp[i];
            }
        }

        public void ShiftRight()
        {
            int[] temp = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp[i] = array[i, array.GetLength(1) - 1];

            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array.GetLength(1) - 1; j > 0; j--)
                {
                    array[i, j] = array[i, j - 1];
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = temp[i];
            }
        }

        public void Start()
        {

            bool RunApp = true;

            ShowArray();

            Console.WriteLine("W - вверх A - влево S - вниз D - вправо\nq - выйти в меню");

            while (RunApp)
            {
                char key = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(0, 1);

                if (key == 'W' || key == 'w')
                {
                    ShiftUp();
                    ShowArray();
                }
                else if (key == 'A' || key == 'a')
                {
                    ShiftLeft();
                    ShowArray();
                }
                else if (key == 'S' || key == 's')
                {
                    ShiftDown();
                    ShowArray();
                }
                else if (key == 'D' || key == 'd')
                {
                    ShiftRight();
                    ShowArray();
                }
                else if (key == 'Q' || key == 'q')
                {
                    RunApp = false;
                }
                else
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Пошла нахуй шлюха");
                }
            }
        }

    }
}
