using System;
/* Question : A given company has name, address, phone number, fax number, web site and manager. 
 * The manager has name, surname and phone number.
 * Write a program that reads information about the company and its manager and then prints it on the console
 */
namespace Exercise3_Company_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company Name : ");
            string companyName = Console.ReadLine();

            Console.Write("Company Address : ");
            string companyAddress = Console.ReadLine();

            Console.Write("Company Phone number : ");
            string companyPhoneNumber = Console.ReadLine();

            Console.Write("Company Fax number : ");
            string companyFaxNumber = Console.ReadLine();

            Console.Write("Company Web Site : ");
            string companyWebSite = Console.ReadLine();

            Console.Write("Manager name : ");
            string managerName = Console.ReadLine();

            Console.Write("Manager surname : ");
            string managerSurname = Console.ReadLine();

            Console.Write("Manager Phone Number : ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The " + companyName + " is at " + companyAddress + " and their phone number is " + companyPhoneNumber +
                " and their fax number is " + companyFaxNumber + " and their website is " + companyWebSite + ". Their manager name is "+
                managerName + " " + managerSurname + " and his Phone Number is  " + managerPhoneNumber + ".");

        }
    }
}
