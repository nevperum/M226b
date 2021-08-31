using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ModulTest
{
    class Student : Person
    {
        /// <summary>
        /// prop
        /// </summary>
      public int Studentsemester { get; set; }

        public string Legi_Nummer { get; set; }


        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="Sts"></param>
        /// <param name="n"></param>
        /// <param name="e"></param>
        /// <param name="a"></param>
        public Student(int Sts, string n, string e, string a)
            : base(n, e, a)
        {
            Studentsemester = Sts;
        }
        /// <summary>
        /// Methode
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override string IdentifizierungsID(string Legi_Nummer)
        {
            return Legi_Nummer;
        }




    }
}
