using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class KtoExeption :Exception
    {

        public int errCode { get; set; }

        public KtoExeption()
        {

        }

        public KtoExeption(string message)
            : base(message)
        {

        }

        public KtoExeption(int _errCode, string message)
            : this(message)
        {
            errCode = _errCode
        }

        public KtoExeption(int _errCode, string message, Exception inner) 
            : this(_errCode, message)
        {

        }

        public KtoExeption(string message, Exception inner)
            : base(message,inner)
        {

        }

        public string FormatMessage()
        {
            return string.Format($"KTO-{errCode:000}-{base.Message}");
        }


    }
}
