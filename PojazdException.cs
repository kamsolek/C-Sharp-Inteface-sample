using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    public class PojazdException : Exception
    {
        public PojazdException(string message) : base(message) { }
    }

}
