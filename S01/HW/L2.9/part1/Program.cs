namespace part1;
using System.Diagnostics;
class Program
{
    public static int Factorial(int n)
    {
    Trace.Assert(0 <=n);
    if(n==0)
        return 1 ;
    int result = 1;
    for(int i =1;i<=n;i++)
        result = result * i;
    return result;
    }

    static void Main(string[] args)
    {
        int n = -8;
        Console.WriteLine(Factorial(n));
    }
}
