using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkStankin4
{
    class withMassive
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальное число списка: ");
            Int32.TryParse(Console.ReadLine(), out int minNumber);
            Console.Write("Введите максимальное число списка: ");
            Int32.TryParse(Console.ReadLine(), out int maxNumber);
            Console.Write("Введите, чему равен шаг в списке: ");
            Int32.TryParse(Console.ReadLine(), out int step);
            if (maxNumber < minNumber)
            {
                Console.WriteLine("Максимальное число не может быть меньше минимального!");
            }
            else if (maxNumber - minNumber <= step)
            {
                Console.WriteLine("Разница между максимальным и минимальным числом должна быть больше шага!");
            }
            else
            {
                Print(createMassive(minNumber, maxNumber, step));
            }

        }
        static int[] createMassive(int minNumber, int maxNumber, int step)
        {
            int[] numbers = new int[];
            for (int i = minNumber; i <= maxNumber; i += step)
            {
                numbers[i] = i;
            }
            return numbers;
        }

        static void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
