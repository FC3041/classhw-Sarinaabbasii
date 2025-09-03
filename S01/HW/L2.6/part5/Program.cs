namespace part5;

class Program
{
    public static void PrintMonth(int monthnumber)
    {
        string[] months = { "Jan" , "Feb" , "Mar" , "Apr" , "May" , "Jun", "Jul" ,  "Aug" , "Sep" , "Oct" , "Nov" , "Dec"};
    Console.WriteLine(monthnumber + " " + months[monthnumber-1]);
}
    static void Main(string[] args)
    {

    for(int i=1;i<=12;i++)
        PrintMonth(i);
    }
}
