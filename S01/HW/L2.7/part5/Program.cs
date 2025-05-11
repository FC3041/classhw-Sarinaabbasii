namespace part5;

class Program
{
    public static int Fibonacci(int n)
    {
        if(n==1 ||n==2)
            return 1;
        return Fibonacci(n-1)+Fibonacci(n-2);
    }
        static void Main(string[] args)
    {
        int n = 20;
        for(int i=1;i<=n;i++)
            Console.WriteLine(Fibonacci(i));
    }
}
