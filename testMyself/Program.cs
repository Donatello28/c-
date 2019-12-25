using System;

namespace testMyself
{
    class Program
    {
        static void Main(string[] args)
        {
            fraction[] arr = new fraction[4];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( $"Enter :{i + 1} Element");
                arr[i] = new fraction(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].X + "/" + arr[i].Y);
            }
        }
    }
}
