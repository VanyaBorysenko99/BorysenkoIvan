using System;

namespace Git
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(1, 26);
            }

        }
    }
}
