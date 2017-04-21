using System;



namespace Age
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string format = "MM.dd.yyyy";
            
        
            DateTime today = DateTime.Now.AddMonths(-7);
            DateTime inputDate = DateTime.ParseExact(input, format,null);

           // Console.WriteLine(today);
           // Console.WriteLine(inputDate);


            int years = today.Year - inputDate.Year;
            int result= 0;

            if (today.Month > inputDate.Month)
            {
                result = years;
            }

            else if((today.Month == inputDate.Month && today.Day>=inputDate.Day))
            {
                result = years;
            }
            else if ((today.Month == inputDate.Month && today.Day < inputDate.Day))
            {
                result = years - 1;
            }
            else
            {
                result = years - 1;
            }
         
            Console.WriteLine(result);
            Console.WriteLine(result + 10);
        }
    }
}


