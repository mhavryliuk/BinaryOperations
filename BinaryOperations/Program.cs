using System;

// Пример перезагрузки бинарных операций

namespace BinaryOperations
{
    class Program
    {
        static void Main()
        {
            DemoArray oneArray = new DemoArray(1, -4, 3, -5, 0);
            DemoArray twoArray = new DemoArray(3, 6, 10, 0, -2);
            DemoArray threeArray = oneArray + twoArray;
            DemoArray fourArray = oneArray + 5;
            DemoArray fiveArray = oneArray - 3;
            DemoArray sixArray = twoArray & threeArray;

            Console.Write("Первый массив: ");
            oneArray.Show();
            Console.Write("Второй массив: ");
            twoArray.Show();
            Console.Write("Третий массив: ");
            threeArray.Show();
            Console.Write("Четвертый массив: ");
            fourArray.Show();
            Console.Write("Пятый массив: ");
            fiveArray.Show();
            Console.Write("Шестой массив: ");
            sixArray.Show();

            Console.ReadKey();
        }
    }
}