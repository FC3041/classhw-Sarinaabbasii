namespace part3;

class Program
{
    public static void PrintRightTriangle(int trianglebase)
    {   
        for(int i=1; i<(trianglebase+1); i++)
        {
            for(int j=0 ; j<(trianglebase-i);j++)
            {
                Console.Write(" ");
            }
            for(int k=1; k<=i;k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int trianglebase = 20;
        PrintRightTriangle(trianglebase);
    }
}
