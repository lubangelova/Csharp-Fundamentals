using System;


namespace MultiplicatorSign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a*b*c<0)
            {
                Console.WriteLine("-");
            }
            else if (a*b*c==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
