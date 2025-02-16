namespace part6;

class Program
{
    public static int DaysInMonth(int monthNumber)
    {
        if(monthNumber==4 || monthNumber==6 || monthNumber==9 || monthNumber==11)
            return 30;
        if(monthNumber==2)
            return 28;
    return 31;
}
    static void Main(string[] args)
    {
        int n = 2;
        Console.WriteLine(DaysInMonth(n));
    }
}
