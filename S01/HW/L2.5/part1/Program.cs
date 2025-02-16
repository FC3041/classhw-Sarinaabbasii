namespace part1;

class Program
{
    public static void FtoC(float f)
    {
        float c = (f-32)* 5 / 9 ;
        Console.WriteLine($"c={c:F2},f={f:F2}");
    }
    static void Main(string[] args)
    {
        float f = 30.00F ;
        FtoC(f);
    }
}
