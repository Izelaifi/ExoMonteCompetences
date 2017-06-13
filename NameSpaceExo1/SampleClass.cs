using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleNameSpace
{
    class SampleClass
    {
        public void SampleMethode()
        {
            System.Console.WriteLine("SampleMethod inside SampleNameSpace");

        }
    }

    namespace NestedNameSpace
    {
        class SampleClass
        {
            public void SampleMethode()
            {
                System.Console.WriteLine("SampleMethod inside NestedNameSpace");

            }
        }
    }
}
