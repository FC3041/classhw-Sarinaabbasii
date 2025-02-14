namespace part2;

class Program
{
    public static long Factorial(int n)
    {
        long result = 1;
        for(int i=1 ;i<=n ; i++)
        {
            result = result * i;
        }
    return result;
}
    static void Main(string[] args)
    {
        for(int n=1;n<21;n++)
            Console.WriteLine(Factorial(n));
    }
}
