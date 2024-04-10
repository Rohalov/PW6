using task2;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new HashSet<int>();
        numbers.FillRandomNum(50);
        ShowEvenNumers(numbers);
    }

    private static void ShowEvenNumers(HashSet<int> numbers)
    {
        Console.WriteLine("Парні числа");
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.Write(num);
                Console.Write(new string(' ', 3));
            }
        }
    }
}