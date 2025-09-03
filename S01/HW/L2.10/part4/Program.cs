namespace part4;

class Program
{
    public static  double AbsValue(double x) 
    {
        if (x < 0) 
        {
            return -x;
        }
        return x;
    }

    public static double SinDegrees(double x, double precision) 
    {
        x = x *  3.141592653589793 / 180;
        double an = x; 
        double sum = an;  
        int n = 1; 
        int sign = -1;

        while (AbsValue(an) > precision) 
        {
            n += 2;  
            an*= (x*x)/(n*(n - 1)); 
            sum += sign*an; 
            sign *= -1; 
        }
        return sum;
    }

    static void Main(string[] args)
    {
        double precision = 0.000001; 
        int x = 45;
        Console.WriteLine(SinDegrees(x, precision));
    }
}
