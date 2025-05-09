public static class EXT
{
    public static string Encoder(this string str)
    {
        return Process(str,3);
    }
    public static string Decoder(this string str)
    {
        return Process(str,-3);
    }

    private static string Process(string text, int shift)
    {
    string result = "";
    for (int i = 0; i < text.Length; i++)
    {
        char ch = text[i];
        
        if (ch >= 'A' && ch <= 'Z')
        {
            char newCh = (char)(ch + shift);
            if (newCh > 'Z')
            {
                newCh = (char)(newCh - 26);
            }
            if (newCh < 'A')
            {
                newCh = (char)(newCh + 26);
            }
            result += newCh;
        }

        else if (ch >= 'a' && ch <= 'z')
        {
            char newCh = (char)(ch + shift);
            if (newCh > 'z')
            {
                newCh = (char)(newCh - 26);
            }
            if (newCh < 'a')
            {
                newCh = (char)(newCh + 26);
            }
            result += newCh;
        }
        else
        {
            result += ch;
        }
    }
    return result;
}

}