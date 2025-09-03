namespace part4;

class Program
{
    public static int IsDivisible(int a, int b)
    {
        if(a>b)
        {
            if(a%b==0)
            {
                return 1;
            }
            else
                return 0;
        }
        else
            return 0;
    }

    public static int IsPrime(int n)
    {
        for(int i=2;i<n;i++)
        {
            if(IsDivisible(n,i)==1)
                return 0;
        }
    return 1;
}
    static void Main(string[] args)
    {
        for(int i=2 ; i<100;i++)
        {
            if(IsPrime(i)==1)
                Console.WriteLine(i);
        }
    }
}
