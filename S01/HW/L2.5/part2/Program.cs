namespace part2;

class Program
{
    public static void CtoF(float c)
    {
        float f = c* 1.8F + 32;
        Console.WriteLine($"c={c:F2},f={f:F2}");
    }
    static void Main(string[] args)
    {
        float c = 30.00F ;
        CtoF(c);
    }
}
