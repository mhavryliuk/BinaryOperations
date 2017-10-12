using System;

namespace BinaryOperations
{
    class DemoArray
    {
        int[] MyArray;

        // Конструктор 1
        public DemoArray(params int[] array)
        {
            MyArray = new int[array.Length];
            Array.Copy(array, MyArray, array.Length);
        }

        // Конструктор 2
        public DemoArray(DemoArray array)
        {
            MyArray = new int[array.Length];
            Array.Copy(array.MyArray, MyArray, array.Length);
        }

        // Метод, выводящий объект-массив на экран
        public void Show()
        {
            foreach (int item in MyArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        // Свойство возвращающее размерность массива
        public int Length
        {
            get { return MyArray.Length; }
        }

        // Индексатор
        public int this[int i]
        {
            get
            {
                if (i < 0 || i > MyArray.Length)
                {
                    Console.WriteLine("Индекс {0} выходит за границы массива", i);
                    return 0;
                }
                else { return MyArray[i]; }
            }
            set
            {
                if (i < 0 || i >= MyArray.Length)
                {
                    Console.WriteLine("Индекс {0} выходит за границы массива", i);
                }
                else { MyArray[i] = value; }
            }
        }

        // Добавляем к каждому элементу массива заданное число
        public static DemoArray operator +(DemoArray x, int a)
        {
            DemoArray temp = new DemoArray(x);
            for (int i = 0; i < x.Length; i++)
            {
                temp[i] = x[i] + a;
            }
            return temp;
        }

        // Из каждого элемента массива вычитаем заданное число
        public static DemoArray operator -(DemoArray x, int a)
        {
            DemoArray temp = new DemoArray(x);
            for (int i = 0; i < x.Length; i++)
            {
                temp[i] = x[i] - a;
            }
            return temp;
        }

        // Поэлементно складываем два массива
        public static DemoArray operator +(DemoArray x, DemoArray y)
        {
            if (x.Length == y.Length)
            {
                DemoArray temp = new DemoArray(x);
                for (int i = 0; i < x.Length; i++)
                {
                    temp[i] = x[i] + y[i];
                }
                return temp;
            }
            else
            {
                Console.WriteLine("Несоответствие размерностей массивов");
                return null;
            }
        }

        // Поэлементное сравнение двух массивов (если элементы совпадают - 1, иначе - 0)
        public static DemoArray operator &(DemoArray x, DemoArray y)
        {
            if (x.Length == y.Length)
            {
                DemoArray temp = new DemoArray(x);
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == y[i]) temp[i] = 1;
                    else temp[i] = 0;
                }
                return temp;
            }
            else
            {
                Console.WriteLine("Несоответствие размерностей массивов");
                return null;
            }
        }
    }
}
