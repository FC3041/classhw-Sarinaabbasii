namespace part3;
class Program
{
    public static void Factorial(int n)
    {
        long result = 1;
        for(int i=1 ;i<=n ; i++)
        {
            result = result * i;
        }
    Console.WriteLine(result);
}
    static void Main(string[] args)
    {
        int n = 18;
        Factorial(n);
    }
}
