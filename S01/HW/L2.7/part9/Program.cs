namespace part9;

class Program
{
    public static int IsLeapYear(int n)
    {
        if(n%4==0 && n%100!=0)
            return 1;
        return 0;
    }

    public static int DaysInMonth(int monthnumber,int year)
    {
        if(monthnumber==4 || monthnumber==6 || monthnumber==9 || monthnumber==11)
        return 30;
        if(monthnumber==2)
        {
            if(IsLeapYear(year)==1)
                return 29;
            return 28;
        }
        return 31;
    }

    public static int DaysBeforeDate(int year, int monthnumber, int daynumber)
    {    
        int sum = 0;
        for(int i=1;i<monthnumber;i++)
            sum += DaysInMonth(i,year);
        return sum+daynumber-1;
    }
    static void Main(string[] args)
    {
    int year=2014;
    int monthnumber=3;
    int daynumber=26;
    int result = DaysBeforeDate(year,monthnumber,daynumber)%7;
        Console.WriteLine(result+2);
    }
}
