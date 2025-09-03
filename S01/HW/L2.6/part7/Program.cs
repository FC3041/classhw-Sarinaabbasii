namespace part7;

class Program
{
    static void Main(string[] args)
    {
        for(int a=1 ;a<100;a++)
        {
            for(int b=1;b<100;b++)
            {
                for(int c=1;c<100;c++)
                {
                    if(a*a + b*b==c*c)
                    {
                        Console.WriteLine("a = "+ a + " b = " + b + " c = " + c);
                    }
                }
            }
        }
    }
}
