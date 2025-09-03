namespace hw;
using System;
using System.Linq;

class Program
{

    public static void reverseAll(string str , out string srev)
    {
        srev = "";
        foreach(char c in str) 
        {
            srev = c + srev;
        }
    }
    public static void reverseWords(string str , out string swrev)
    {
      string[] s = str.Split(' '); 
        swrev = ""; 
        for (int i = s.Length - 1; i >= 0; i--)
        {
            swrev += s[i] + " ";
        }
        
    }
    static void Main(string[] args)
    {
        string str = "sallam sarina";
        string srev;
        string swrev;

        reverseAll(str, out srev);
        reverseWords(str , out swrev );
        System.Console.WriteLine(srev);
        Console.WriteLine(swrev);
    }
}
