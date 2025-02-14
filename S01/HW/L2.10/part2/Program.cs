namespace part2;

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


    public static long Power(int x , int y)
    {
        long result = 1;
        for(int i=1;i<=y;i++)
        {
            result = result*x;
        }
        return result;
    }

    public static double Exp1(int x , double precision)
    {
        double ex = 0.0D;
        int n = 0;
        int i = 0;
        while(precision <= Power(x,i)/(double)Factorial(n))
        {
            ex += Power(x,i)/(double)Factorial(n);
            i += 1;
            n += 1;
        }
        return ex;
    }
    static void Main(string[] args)
    {
        double precision = 0.000001;
        int x = 2;
        Console.WriteLine(Exp1(x,precision));
    }
}
