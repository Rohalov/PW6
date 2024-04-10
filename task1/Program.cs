using task1;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[50];
        //ExtentionMethod
        numbers.FillRandomNum();

        ShowPositiveValues(numbers);
    }

    private static void ShowPositiveValues(int[] numbers)
    {
        Console.WriteLine("Додатні числа:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                Console.Write(i);
                Console.Write(new string(' ', 3));
            }
        }
    }
}