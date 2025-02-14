namespace part4;

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
        for(int n=1;n<21;n++)
            Factorial(n);
    }
}
