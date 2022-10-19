using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //_______________________Assignment___________________ //


            // Problem 1: print triangle and allow user to height of it in .
            Console.WriteLine("Print traingle and allow height of it in : ");
            Console.WriteLine("Press ENTER to proceed to the solution");
            Console.ReadLine();
            Console.WriteLine("Set the height of triangle:");
            int n = Convert.ToInt32(Console.ReadLine());
            int star = 1;
            for (int i = 0; i < n; i++)
            {
                int space = n - i - 1;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < star; k++)
                {
                    Console.Write("*");
                }
                star += 2;
                Console.WriteLine();


            }
            Console.WriteLine("Find valid date from string: ");
            Console.WriteLine("Press ENTER to proceed into next problem solution");
            Console.ReadLine();


            // Problem 2: find valid date (MMDDYYYY) from string;

           
            string date_valid = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021  idf32432 32423 d34234jh dfh";
            var regex = new Regex(@"\b\d{2}\d{2}\d{4}\b");
            foreach (Match m in regex.Matches(date_valid))
            {
                DateTime dt;
                if (DateTime.TryParseExact(m.Value, "MMddyyyy", null, DateTimeStyles.None, out dt))
                {
                    Console.WriteLine("The date is valid "+dt.ToShortDateString());   
                }
                else
                {
                    Console.WriteLine("Date is Invalid");
                }
                Console.ReadKey();
            }
        }
    
    }
}
