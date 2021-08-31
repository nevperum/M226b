using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inizieren
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("Hans", "Müller", "Verkauf");
            employees[1] = new Employee("Natalie", "Weinfeld", "Verkauf");
            employees[2] = new Employee("Pascal", "Merz", "Verkauf");
            employees[3] = new Employee("John", "Mc Cullem", "Lager");
            employees[4] = new Employee("Jo", "Mc Cullem", "Lager");

            Array.Sort(employees);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Department}, {employee.LastName}, {employee.FirstName}");
            }

            Console.ReadLine();
        }
    }
}
