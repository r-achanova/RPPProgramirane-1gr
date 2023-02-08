using System;

namespace StatisticArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("count="+OptionsManager.CountLess100(arr));
            Console.WriteLine($"sum={OptionsManager.MaxNum(arr)}");
            OptionsManager.PrintEvensNum(arr);
            arr=OptionsManager.ReverseArr(arr);
            OptionsManager.PrintArr(arr);
            // TO DO
        }
    }
}
