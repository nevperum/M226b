using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ModulTest
{
    class Kurse 
    {
        /// <summary>
        /// prop
        /// </summary>
       public int Identifikationsnummer { get; set; }
        /// <summary>
        /// prop
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// verbindung
        /// </summary>
        public List<Professor> Professoren { get; set; } = new List<Professor>();
        /// <summary>
        /// Verbindung
        /// </summary>
        public List<Student> StudenK { get; set; } = new List<Student>();
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="n"></param>
        /// <param name="Identif"></param>
        public Kurse(string n,int Identif)
        {
            Name = n;
            Identifikationsnummer = Identif;
        }




    }
}
