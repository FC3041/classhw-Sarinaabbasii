namespace part5;

class Program
{
    public static double SquareRoot(double x, double precision)
    {
        if(x>=0)
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
    
    return 0;
    }

    static void Main(string[] args)
    {
        double precision = 0.000001;
        int x = 2;
        Console.WriteLine(SquareRoot(x, precision));
    }
}
