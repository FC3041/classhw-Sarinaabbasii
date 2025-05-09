namespace part1;

class Program
{
    public static long Factorial(int n)
    {
        long result = 1;
        for(int i =1;i<=n;i++)
        {
            result = result * i;
        }
        return result;
    }

    public static double EulersConstant(double precision)
    {
        double e = 0.0D;
        int n = 0;
        while(precision <= 1/(double)Factorial(n))
        {
            e += 1/(double)Factorial(n);
            n += 1;
        }
        return e;
    }
    static void Main(string[] args)
    {
        double precision = 0.0001;
        Console.WriteLine(EulersConstant(precision));
    }
}
