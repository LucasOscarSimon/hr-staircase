using System;
class Solution
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; ++i)
        {
            string output = new string(' ', N - i) + new string('#', i);
            Console.WriteLine(output);
        }
        Console.ReadLine();
    }
}