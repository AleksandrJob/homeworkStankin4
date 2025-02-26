namespace homeworkStankin4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальное число списка: ");
            Int32.TryParse(Console.ReadLine(), out int minNumber);
            Console.Write("Введите максимальное число списка: ");
            Int32.TryParse(Console.ReadLine(), out int maxNumber);
            Console.Write("Введите, чему равен шаг в списке: ");
            Int32.TryParse(Console.ReadLine(), out int step);
            if(maxNumber < minNumber)
            {
                Console.WriteLine("Максимальное число не может быть меньше минимального!");
            }
            else if(maxNumber - minNumber <= step)
            {
                Console.WriteLine("Разница между максимальным и минимальным числом должна быть больше шага!");
            }
            else
            {
                Print(createList(minNumber, maxNumber, step));
            }
                
        }
        static List<int> createList(int minNumber, int maxNumber, int step)
        {
            List <int> numbers = [];
            for(int i = minNumber; i <= maxNumber; i += step)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        static void Print(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
