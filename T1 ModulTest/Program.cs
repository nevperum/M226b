using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ModulTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initzieren
            Student student1 = new Student(23974324,"Kevin","kevin.h@ölksd.ch", "Laufen 4242");

            Professor professor1 = new Professor(23973244, "Bill Gates", "Billgates.h@ölksd.ch", "Wahlen 4246");

            Kurse kurse1 = new Kurse("c# Kurs", 80943);
            // Hinzufügen in Kurse
            kurse1.Professoren.Add(professor1);

            kurse1.StudenK.Add(student1);

            // anzeigen
            foreach (var item in kurse1.Professoren)
            {
                Console.WriteLine($" Dozenten: {item.Name}\n Lohn: {item.Lohn}\n Email: {item.Email}\n Adresse  {item.Adresse}\n");
            }

            foreach (var item in kurse1.StudenK)
            {
                Console.WriteLine($" Dozenten: {item.Name}\n Demester{item.Studentsemester} \n Email: {item.Email}\n Adresse  {item.Adresse}\n");
            }
            Console.ReadLine();



        }
    }
}
