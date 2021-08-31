using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_ModulTest
{
   class Professor : Person
    {
        /// <summary>
        /// prop
        /// </summary>
       public int Lohn { get; set; }

        public string AHV_Nummer{ get; set; }

    /// <summary>
    /// /ctor
    /// </summary>
    /// <param name="lohn"></param>
    /// <param name="n"></param>
    /// <param name="e"></param>
    /// <param name="a"></param>
    public Professor(int lohn, string n, string e, string a)
            : base( n,e,a)
        {
            Lohn = lohn;
        }
        /// <summary>
        /// Methode
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override string IdentifizierungsID(string AHV_Nummer)
        {
            return AHV_Nummer;
        }
    }
}
