namespace part3B;

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


    public static double Exp2(int x,double precision)
    {
        double an = 1;
        double sum = 1;
        int n = 1;
    while(an >= precision)
    {
        an *= (double)x / n ;
        sum += an;
        n++;
    }
    
    return sum;
    }
    public static  double AbsValue(double x) 
    {
        if (x < 0) 
        {
            return -x;
        }
        return x;
    }

    public static string Near(double x, double y, double closeness) 
    {
        double max = 0;
        if(AbsValue(x)>AbsValue(y))
            max  = AbsValue(x);
        else
            max = AbsValue(y);
        if(AbsValue(x - y) <= closeness * max)
            return "True";
        return "False";
    }
    static void Main(string[] args)
    {
        int x = 1;
        double precision = 0.000001D;  
        double result1 = Exp1(x, precision);
        double result2 = Exp2(x, precision);
        Console.WriteLine(Near(result1,result2,precision));
    }
}
