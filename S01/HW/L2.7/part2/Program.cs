namespace part2;

class Program
{
    public static long Factorial(int n)
    {
        if(n<0)
        {
            return 0;
        }
        
        long result = 1;
        for(int i=1 ;i<=n ; i++)
        {
            result = result * i;
        }
    return result;
}
    static void Main(string[] args)
    {
        for(int n=1;n<21;n++)
        {
            if(Factorial(n)==0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(Factorial(n));
            }
        }
    }
}
