using System;


namespace intDoubleString
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();

            if (type=="integer")
            {
                int newValue = int.Parse(value)+1;
                Console.WriteLine(newValue);
            }
            else if (type == "real")
            {
                double newValue = double.Parse(value) + 1;
                Console.WriteLine("{0:F2}",newValue);
            }
            else if (type=="text")
            {
                string newValue = value + "*";
                Console.WriteLine(newValue);
            }
          
        }
    }
}
