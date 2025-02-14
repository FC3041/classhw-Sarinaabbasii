namespace part3_a;

class Program
{
    public static  double AbsValue(double x) 
    {
        if (x < 0) 
        {
            return -x;
        }
        return x;
    }

 public static string Near(double x, double y, double closeness) 
{
    double max = 0;
    if(AbsValue(x)>AbsValue(y))
        max  = AbsValue(x);
    else
        max = AbsValue(y);
    if(AbsValue(x - y) <= closeness * max)
        return "True";
    return "False";
}
    static void Main(string[] args)
    {
    double x = 5.0;
    double y = 5.0005;
    double closeness = 0.001;
    Console.WriteLine(Near(x,y,closeness));
    }
}
