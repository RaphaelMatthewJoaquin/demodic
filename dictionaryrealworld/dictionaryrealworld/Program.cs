using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryrealworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =  
            {
                new Employee("CEO", "MATTHEW", 20, 100000),
                new Employee("MANAGER", "MATTHEW", 21, 400),
                new Employee("HR", "MATTHEW", 22, 1170),
                new Employee("LEAD DEVELOPER", "MATTHEW", 23, 277353),
                new Employee("INTERN", "MATTHEW", 24, 6900),
            };

            Dictionary<string, Employee> employeedic = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeedic.Add(emp.Role, emp);
            }

            foreach(Employee emp in employeedic.Values) 
            {
                Console.Write(" EMPLOYEE NAME: {0}", emp.Name);
                Console.Write(" EMPLOYEE ROLE: {0}", emp.Role);
                Console.Write(" EMPLOYEE AGE: {0}", emp.Age);
                Console.WriteLine(" EMPLOYEE SALARY: {0}", emp.Salary);
                Console.WriteLine("-----------------------------------------------------------");

            }


            /*string key = string.Empty;

            while(key != "N" )
            {


                Console.WriteLine("CONTAINS SAMPLE");

                key = Console.ReadLine();

                if (employeedic.ContainsKey(key))
                {
                    Employee emp = employeedic[key];

                    Console.WriteLine("EMPLOYEE NAME: {0}, ROLE: {1}, SALARY: {2}", emp.Name, emp.Role, emp.Salary);
                }
                else
                {
                    Console.WriteLine("NO EMPLOYEE FOUND");
                }*/


            string keytoupdate = "CEO";
            

            if (employeedic.ContainsKey(keytoupdate))
            {
                employeedic[keytoupdate] = new Employee("CEO", "DANTE", 117, 1);
                Console.WriteLine("DUE TO SOME VIOLATION OF CONTRACT BY EMPLOYEE ");
   
                Console.WriteLine("AND WAS REPLACED WITH {0}", keytoupdate);

            }
            else
            {
                Console.WriteLine("NO EMPLOYEE HAS BEEN FOUND WITH THIS KEY {0}", keytoupdate);
            }

            foreach (Employee emp in employeedic.Values)
            {
                Console.Write(" EMPLOYEE NAME: {0}", emp.Name);
                Console.Write(" EMPLOYEE ROLE: {0}", emp.Role);
                Console.Write(" EMPLOYEE AGE: {0}", emp.Age);
                Console.WriteLine(" EMPLOYEE SALARY: {0}", emp.Salary);
                Console.WriteLine("-----------------------------------------------------------");

            }

            string keytoremove = "INTERN";

            if (employeedic.Remove(keytoremove))
            { 
                Console.WriteLine("EMPLOYEE {0} HAS BEEN TERMINATED", keytoremove);
            }
            else
            {
                Console.WriteLine("EMPLOYEE NOT FOUND");
            }


            foreach (Employee emp in employeedic.Values)
            {
                Console.Write(" EMPLOYEE NAME: {0}", emp.Name);
                Console.Write(" EMPLOYEE ROLE: {0}", emp.Role);
                Console.Write(" EMPLOYEE AGE: {0}", emp.Age);
                Console.WriteLine(" EMPLOYEE SALARY: {0}", emp.Salary);
                Console.WriteLine("-----------------------------------------------------------");

            }


            Console.ReadLine();
            
        }
    }
}
