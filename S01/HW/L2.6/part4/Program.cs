namespace part4;

class Program
{
    public static void PrintCone(int basesize)
    {
        if(basesize%2==1)
        {
            int x = (basesize-1)/2;
            int i=1;
            for(int j=0;j<x;j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("^");
            for(i=1;i<=x;i++)
            {   
                for(int j=1; j<=(x-i);j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i;j++)
                {
                Console.Write("/");
                }
            Console.Write("|");
            for(int j=1; j<=i;j++)
            {
                Console.Write("\\");  
            }    
            Console.WriteLine("");
        }
    }
}
    static void Main(string[] args)
    {
    int basesize=9;
    for(int i=1;i<=basesize;i++)
        PrintCone(i);
    }
}
