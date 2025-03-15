namespace part1;

class Program
{
    public static int AbsoluteValue(int x)
    {
    if(x>0)
    {
        return x;
    }
    else
    {
        return -x;
    }
}
    static void Main(string[] args)
    {
    int x = -90;
    Console.WriteLine(AbsoluteValue(x));
    }
}
