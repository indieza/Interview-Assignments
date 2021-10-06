using System;

namespace ExtendSealedClass
{
    public class StartUp
    {
        private static void Main()
        {
            SealedClass sealedClass = new SealedClass();
            string result = sealedClass.ExtensionMethodOne("My First Message For Extension Method!");
            Console.WriteLine(result);
        }
    }
}