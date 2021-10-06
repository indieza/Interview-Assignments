using System;

namespace ExtendSealedClass
{
    public sealed class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("Hello \"Sealed\" Constructor!");
        }

        public void MethodOne()
        {
            Console.WriteLine("Hello Method One!");
        }
    }
}