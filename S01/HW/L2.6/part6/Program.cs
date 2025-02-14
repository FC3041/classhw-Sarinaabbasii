namespace part6;

class Program
{
    public static void ComputeChange(int n)
    {
        if(n<100)
        {   
            n = 100-n;
            int quarters = n/25;
            Console.WriteLine("quarters = " + quarters);
            n = n%25;

            int dimes = n/10;
            Console.WriteLine("dimes = " + dimes);
            n = n%10;

            int nickels = n/5;
            Console.WriteLine("nickels = "+ nickels);
            n = n%5;

            int pennies = n;
            Console.WriteLine("pennies = " + pennies);
        }
    }     
    static void Main(string[] args)
    {
        int n=8;
        ComputeChange(n);
    }
}
