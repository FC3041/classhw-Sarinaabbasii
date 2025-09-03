namespace part2;
using System.Diagnostics;
class Program
{
    public static int IsDivisible(int a, int b)
    {
    Trace.Assert(b!=0 && a>b);
        if(a%b==0)
            return 1;
        return 0;
    } 
    
    public static int IsPrime(int N)
    {
        Trace.Assert(0<=N);
        if(N==1)
            return 0;

        if(N>1)
            for(int i=2;i<N;i++)
            if(IsDivisible(N , i)==1)
                return 0;
        return 1;
}
    static void Main(string[] args)
    {
    for(int N = -1 ; N<100;N++)
    {
        if(IsPrime(N)==1)
            Console.WriteLine(N);
    }
    }
}
