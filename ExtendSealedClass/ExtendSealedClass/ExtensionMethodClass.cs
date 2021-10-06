using System;

namespace ExtendSealedClass
{
    public static class ExtensionMethodClass
    {
        public static string ExtensionMethodOne(this SealedClass sealedClass, string message)
        {
            return $"Welcome to the Extension Method!\nMessage: {message}";
        }
    }
}