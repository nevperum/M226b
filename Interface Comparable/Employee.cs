using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Comparable
{
    class Employee : IComparable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="department"></param>
        public Employee(string firstName, string lastName, string department)
        {

            FirstName = firstName;

            LastName = lastName;

            Department = department;


        }

        

            public int CompareTo(object obj)
            {
                Employee employee = obj as Employee;

                if ((FirstName.CompareTo(employee.FirstName) < 0))
                   
                    // dann muss ein Wert kleiner 0 zurückgegeben  werden 
                    return -1;
                else if ((FirstName.CompareTo(employee.FirstName) == 0))
                  
                    // Diese Instanz ist gleich der übergebenen, dann
                    // muss 0 zurückgegeben werden
                    return 0;
                else
                    // Diese Instanz ist größer als die übergebene,
                    // dann muss ein Wert > 0 zurückgegeben werden
                    return 1;
            }
        
    }
}
