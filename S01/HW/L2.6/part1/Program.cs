namespace part1;

class Program
{
    public static void IsLeapYear(int n)
    {
        if(n%4==0 && n%100!=0)
        {
            Console.WriteLine(n+"=true",n);
        }
    Console.WriteLine(n+"=false");
}
    static void Main(string[] args)
    {
    int n = 2006;
    IsLeapYear(n);
    }
}
