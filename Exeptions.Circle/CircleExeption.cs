using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions.Circle
{
    
        public class CircleException : Exception
        {
        /// <summary>
        /// eigenschaft
        /// </summary>
            public int CircleErrorNum { get; set; }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="message"></param>
            public CircleException(string message)
                : base(message)
            {

            }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorNum"></param>
        public CircleException (string message, int errorNum)
           : this(message)
        {
            CircleErrorNum = errorNum;
        }

        }

}
