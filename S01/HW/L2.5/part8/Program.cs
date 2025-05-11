namespace part8;

class Program
{
    public static void main1(int n)
    {   
        long sum = 0;
        for(int i=1;i<=n;i++)
        {
            sum = sum + i*i;
        }
        float result1 = ((float)sum)/n ;
        Console.WriteLine(result1);
}

    static void Main(string[] args)
    {
        int n = 4;
        main1(n);
    }
}
