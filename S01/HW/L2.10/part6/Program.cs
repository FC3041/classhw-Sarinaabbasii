namespace part6;

class Program
{
    public static long Power(int x , int y)
    {
        long result = 1;
        for(int i=1;i<=y;i++)
        {
            result = result*x;
        }
        return result;
    }
    public static double SquareRoot(double x,int n, double precision)
    {
        if(x<0 && n%2==0)
            return 0;
        else
        {
        double lowerBound = 0;
        double upperBound= x;
        if (x < 1) 
        {
            upperBound= 1;
        }
        double mid = 0;
        while ((upperBound-lowerBound) > precision) 
        {
            mid= (lowerBound+ upperBound) / 2;
            if (mid*mid < x) 
            {
                lowerBound= mid;
            }
            else 
            {
                upperBound= mid; 
            }
        }
        return mid; 
    }

    }
    static void Main(string[] args)
    {
        double precision = 0.000001;
        double x = 2.0D;
        int n=2;
        if(SquareRoot(x,n, precision)!=0)
            Console.WriteLine(SquareRoot(x,n, precision));
        else
            Console.WriteLine("none");
        }
}
