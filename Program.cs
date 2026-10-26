using System;
class Program
{
    static void PrintDiamond(int n)
    {
        if (n <= 0) return;

        int mid = n / 2;
        bool isEven = n % 2 == 0;

        for (int i = 0; i < n; i++)
        {
            int d = Math.Abs(i - mid);
            int spacesBefore = d;

            if (!isEven)
            {
                if (d == mid)
                    Console.WriteLine(new string(' ', spacesBefore) + "X");
                else
                    Console.WriteLine(new string(' ', spacesBefore) + "X" +
                                      new string(' ', n - 2 * d - 2) + "X");
            }
            else
            {
                if (d == mid)
                    Console.WriteLine(new string(' ', spacesBefore) + "XX");
                else if (d == mid - 1)
                    Console.WriteLine(new string(' ', spacesBefore) + "X" +
                                      new string(' ', 2) + "X");
                else
                    Console.WriteLine(new string(' ', spacesBefore) + "X" +
                                      new string(' ', n - 2 * d - 2) + "X");
            }
        }
    }
    static void Main()
    {
        Console.Write("Введите N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        PrintDiamond(N);
    }
}