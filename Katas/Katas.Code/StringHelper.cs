using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Code
{
    public class StringHelper
    {
        public String ReverseString(string inputString)
        {
            return String.Concat(inputString.Reverse());
        }

        public Int32 WordCount(string inputString1)
        {   
            return inputString1.Split(' ').Count();

        }
    }
}
