namespace part3;

class Program
{
    public static double Exp1(int x,double precision)
    {
        double an = 1;
        double sum = 0;
        int n = 1;
    while(an >= precision)
    {
        an *= (double)x / n ;
        sum += an;
        n++;
    }
    
    return sum;
}

    static void Main(string[] args)
    {
        int x = 2;
        double precision = 0.000001;
        Console.WriteLine(Exp1(x,precision));
    }
}
