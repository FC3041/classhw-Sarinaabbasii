namespace part5;

class Program
{
    public static void Power(int x , int y)
{
    long result = 1;
    for(int i=1;i<=y;i++)
        result = result*x;
    Console.WriteLine(result);
}

    static void Main(string[] args)
    {
    int x = 5;
    int y = 4;
    Power(x,y);
    }
}
