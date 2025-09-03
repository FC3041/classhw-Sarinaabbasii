namespace part3;

class Program
{
    public static string IsDivisible(int a, int b)
    {
        if(a>b)
        {
            if(a%b==0)
                return "True";
            else
            return "False";
        }
    return "False";
}
    static void Main(string[] args)
    {
        int a = 7;
        int b = 3;
        Console.WriteLine(IsDivisible(a,b));
    }
}
