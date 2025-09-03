namespace part7;

class Program
{
    public static void main1(int n)
    {   
        long sum = 0;
        for(int i=0;i<n;i++)
        {
            sum = sum + i*i;
        }
        float result1 = ((float)sum)/n ;
        Console.WriteLine(result1);
}

    static void Main(string[] args)
    {
        int n = 5;
        main1(n);
    }
}
