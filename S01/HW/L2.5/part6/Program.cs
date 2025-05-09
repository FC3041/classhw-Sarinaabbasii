namespace part6;

class Program
{
    public static void main1(int a , int b , int c)
    {   
        if(b*b - 4*a*c >0)
        {
            float x1 = (-b + (float)Math.Pow((b*b - 4*a*c),0.5))/ (2*a);
            float x2 = (-b - (float)Math.Pow((b*b - 4*a*c),0.5))/ (2*a);
            Console.WriteLine("x1="+x1);
            Console.WriteLine("x2="+x2);
        }
    
        if(b*b - 4*a*c == 0)
        {
            float x = -b/(2*a);
            Console.WriteLine(x);
        }
        if(b*b - 4*a*c<0)
            Console.WriteLine("none");
    }
    static void Main(string[] args)
    {
        int a = 1;
        int b = -7;
        int c = 12;
        main1(a,b,c);
    }
}
