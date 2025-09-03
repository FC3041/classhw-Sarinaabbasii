namespace part2;

class Program
{
    public static void PrintLeftTriangl(int trianglebase)
{   
    for(int i=1; i<(trianglebase+1); i++)
    {
        if(i%2==1)
        {
            for(int j=0; j<i ; j++)
            {
                Console.Write("%");
            }
            Console.WriteLine("");
        }
        if(i%2==0)
        {
            for(int j=0; j<i ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
    static void Main(string[] args)
    {
        int trianglebase = 20;
        PrintLeftTriangl(trianglebase);
    }
}
