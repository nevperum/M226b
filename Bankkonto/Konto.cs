using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public abstract class Konto : ISchnittstelle
    {

        protected double _balance;

        private DateTime _changedDate;

        public DateTime ChangedDate
            {
            get { return _changedDate; }
            set { _changedDate = value; }
        }


        public double Balance
        {
            get { return _balance; }
        }

        private double _kontostand;





        public DateTime _createdDate { get; }

        public double _limit { get; set; }

        public double _dispValue { get; set; }

        public string _name { get; set; }

        public int _nuber { get; set; }

        public Konto(int number, string name, double limit)
          : this(number, name)
        {
            _name = name;
            _limit = limit;

        }

        /// <summary>
        /// tor
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        public Konto(int number, string name)
            : this(number)
        {
            _name = name;


        }
        public Konto(int number)
        {
            number = _nuber;
        }
        public Konto()
        {



        }

        public double Kontostand
             {
            get
            {
                return _kontostand;
            }
            set
            { _kontostand = value; }



        }

        public virtual void PayIn(double amount)
        {
            if (amount > 0.0)
            {
                _balance += amount;
                _changedDate = DateTime.Now;

            }
        }

        public virtual void PayOut(double amount)
        {
            if (amount > 0.0)
            {
                _balance -= amount;
                _changedDate = DateTime.Now;

            }
        }
    }
}
