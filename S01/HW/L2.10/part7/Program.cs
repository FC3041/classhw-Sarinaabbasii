namespace part7;

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

    public static double Exp1(double x,double precision)
    {
        double an = 1;
        double sum = 1;
        int n = 1;
        while(an >= precision)
        {
            an *= x / n ;
            sum += an;
            n++;
        }
        return sum;
    }
    public static double Ln(double x, double precision)
    {
        if (x <= 0)
        {
            return 0.0D;
        }
        else
        {
            double lowerBound=1;
            double upperBound=1;
            if (x > 1)
            {
                lowerBound = 0;
                upperBound = x;
            }
            else
            {
                lowerBound = -1000000;
                upperBound = 0;
            }
            double mid = 0;
            while ((upperBound-lowerBound)>precision)
            {
                mid = (lowerBound+upperBound)/2.0D;
                double expmid = Exp1(mid, precision);
                if (expmid<x)
                {
                    lowerBound = mid;
                }
                else
                {
                    upperBound = mid;
                }
            }

            return mid;
        }
    }
    static void Main(string[] args)
    {
        int x = 2;
        double precision = 0.0000001;
        if(Ln(x, precision)!=0)
            Console.WriteLine(Ln(x,precision));
        else
            Console.WriteLine("none");
        }
    }
