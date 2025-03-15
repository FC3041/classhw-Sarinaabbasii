namespace part2;

class Program
{
    public static void PrintLeftTriangle(int trianglebase , string str)
    {   
        for(int i=1; i<(trianglebase+1); i++)
        {
            for(int j=0; j<i ; j++)
            {
                Console.Write(str);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        string str = "%";
        int trianglebase = 20;
        PrintLeftTriangle(trianglebase, str);
    }
}
