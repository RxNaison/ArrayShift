using System;

namespace ArrayShift
{
    class Array
    {
        private int[] _array;

        public Array(int size, int rangeRandom)
        {
            _array = new int[size];

            Random random = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = random.Next(rangeRandom);
            }
        }

        public void ShowArray()
        {
            foreach (int number in _array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public void ShiftLeft()
        {
            int temp = _array[0];

            for (int i = 0; i < _array.Length - 1; i++)
            {
                _array[i] = _array[i + 1];

            }

            _array[_array.Length - 1] = temp;

        }

        public void ShiftRight()
        {
            int temp = _array[_array.Length - 1];

            for (int i = _array.Length - 1; i > 0; i--)
            {
                _array[i] = _array[i - 1];

            }

            _array[0] = temp;
        }

        public void Start()
        {

            bool RunApp = true;

            ShowArray();

            Console.WriteLine("A - влево D - вправо\nq - выйти в меню");

            while (RunApp)
            {   
                char key = Console.ReadKey(true).KeyChar;

                Console.SetCursorPosition(0, 1);

                if (key == 'A' || key == 'a')
                {
                    ShiftLeft();                    
                    ShowArray();
                }
                else if (key == 'D' || key == 'd')
                {
                    ShiftRight();
                    ShowArray();
                }
                else if (key == 'Q' || key == 'q')
                {
                    Console.Clear();
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
