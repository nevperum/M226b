using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Sparkonto : Konto
    {
        
        public Sparkonto()
            : base()
        {

        }


        public override void PayOut(double amount)
        {
           
            if (amount > 0.0)
            {
                if()
                _balance -= amount;
                _changedDate = DateTime.Now;

            }
            if (_balance )
        }


    }
}
