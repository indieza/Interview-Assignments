namespace ExtensionMethod
{
    public static class ExtensionClass
    {
        public static int ExtensionMethod(this SealedClass item)
        {
            return item.Sum();
        }
    }
}