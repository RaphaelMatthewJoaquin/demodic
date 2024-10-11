using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var months = new Dictionary<int, string>
            {
                {1, "JANUARY" },
                { 2, "FEB" },
                { 3, "MARCH" },
                { 4, "APRIL" },
                
            };

            months[5] = "may";
            months[6] = "june";
            months[7] = "july";
            months[8] = "august";


            months.Add(9,"september");
            months.Add(10,"OCT");
            months.Add(11,"NOV");
            months.Add(12,"DEC");

            foreach(var s in months)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
