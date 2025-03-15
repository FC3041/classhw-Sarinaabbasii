namespace part7;

class Program
{
    public static int IsLeapYear(int n)
    {
        if(n%4==0 && n%100!=0)
            return 1;
        return 0;
    }


    public static int DaysInMonth(int monthNumber,int year)
    {
        if(monthNumber==4 || monthNumber==6 || monthNumber==9 || monthNumber==11)
            return 30;
        if(monthNumber==2)
        {
            if(IsLeapYear(year)==1)
                return 29;
            return 28;
    }
        return 31;
    }

    static void Main(string[] args)
    {
        int year = 2004;
        int month = 2;
        Console.WriteLine(DaysInMonth(month,year));
    }
}
