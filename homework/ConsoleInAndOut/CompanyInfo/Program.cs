using System;


namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress= Console.ReadLine();
            string phoneNumber= Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string ManagerFirstName = Console.ReadLine();
            string ManagerLastName = Console.ReadLine();
            uint ManagerAge = uint.Parse(Console.ReadLine());
            string ManagerPhone = Console.ReadLine();

            if (faxNumber=="")
            {
                faxNumber = "(no fax)";
            }

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone);

        }
    }
}
