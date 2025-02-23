namespace part1;

class Program
{
    public static void PrintLeftTriangle(int trianglebase)
    {   
        for(int i=1; i<(trianglebase+1); i++)
        {
            for(int j=0; j<i ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int trianglebase = 20;
        PrintLeftTriangle(trianglebase);
    }
}
