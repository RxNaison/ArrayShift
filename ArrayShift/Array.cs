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

                switch (char.ToUpper(key))
                {
                    case 'A':
                    ShiftLeft();                    
                    ShowArray();
                    break;
                
                    case 'D':
                    ShiftRight();
                    ShowArray();
                        break;
                        
                    case 'Q':
                    Console.Clear();
                    RunApp = false;
                        break;
                    default:
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Пошла нахуй шлюха");
                        break;
                }
            }
        }

    }

}
