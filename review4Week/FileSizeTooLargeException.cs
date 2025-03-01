using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review4Week
{
    internal class FileSizeTooLargeException : Exception
    {
        public FileSizeTooLargeException(string msg) :base(msg) { }
    }
}
