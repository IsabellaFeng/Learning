using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.LearnGenerics
{
    public class TestProcessResult
    {
        public TestProcessResult() : this(1)
        {

        }

        public TestProcessResult(int myNumber)
        {
            if (myNumber == 0)
            {
                throw new InvalidOperationException("my number can not be 0");
            }

            MyNumber = myNumber;
        }

        public int MyNumber { get; }
    }
}

