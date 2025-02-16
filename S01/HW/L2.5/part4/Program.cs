namespace part4;

class Program
{
    public static void Factorial(int n)
    {
        if(n<0)
        {
            Console.WriteLine("none");
        }
        else
        {
            long result = 1;
            for(int i=1 ;i<=n ; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
}
    static void Main(string[] args)
    {
        for(int n=1;n<21;n++)
            Factorial(n);
    }
}
