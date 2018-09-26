using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryToTest
{
    public class ClassToTest1
    {

        public int Adder(int n1, int n2)
        {
            if(n1 <0 && n2>0)
            {
                return -1;
            }
            var sum = n1 + n2;
            return sum;
        }
    }
}
