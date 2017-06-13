using System;


namespace SampleNameSpace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            Console.WriteLine("SampleMethod inside SampleNameSpace");
        }
    }

    namespace NestedNameSpace
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                Console.WriteLine("SampleMethod inside NestedNameSpace");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            SampleClass outer = new SampleClass();
            outer.SampleMethod();

            SampleNameSpace.SampleClass outer2 = new SampleNameSpace.SampleClass();
            outer2.SampleMethod();

            NestedNameSpace.SampleClass inner = new NestedNameSpace.SampleClass();
            inner.SampleMethod();

        }
    }
}


