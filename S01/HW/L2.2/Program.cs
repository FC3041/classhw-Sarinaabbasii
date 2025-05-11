namespace L2._2;

class Program
{

    public static void head()
        {
            Console.WriteLine("     ^      ");
            Console.WriteLine("    /|\\    ");
            Console.WriteLine("   //|\\\\  ");
            Console.WriteLine("  ///|\\\\\\");
        }
    public static void body()
    {
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
    }

    public static void line()
    {
        Console.WriteLine(" +-------+  ");
    }

    static void Main(string[] args)
    {
        head();
        line();
        for(int i=0; i<6; i++)
        {
            body();
            line();
        }
        head();
    }
}
