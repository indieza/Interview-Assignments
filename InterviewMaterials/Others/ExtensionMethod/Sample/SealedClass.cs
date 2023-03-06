namespace ExtensionMethod.Sample;

public sealed class SealedClass
{
    private readonly int a;
    private readonly int b;

    public SealedClass(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int Sum() => a + b;
}