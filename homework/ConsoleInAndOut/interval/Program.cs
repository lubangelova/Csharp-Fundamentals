using System;


namespace interval
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i=n+1; i<m; i++)
            {
                if (i % 5==0)
                {
                    count += 1;
                }
          
            }
            Console.WriteLine(count);

        }
    }
}
