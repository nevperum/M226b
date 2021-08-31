using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ModulTest
{
    class Person
    {
        /// <summary>
        /// prop
        /// </summary>
       public string Name { get; set; }
       public string Email { get; set; }
          public string Adresse { get; set; }
        /// <summary>
        /// Methode
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
       public virtual string IdentifizierungsID(string value)
        {
            return value;
        }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="n"></param>
        /// <param name="e"></param>
        /// <param name="a"></param>
        public Person(string n, string e, string a)
        {
            Name = n;
            Email = e;
            Adresse = a;
        }

    }
}

   