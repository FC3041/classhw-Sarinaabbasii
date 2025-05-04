namespace S20;

class Program
{

    static void Main(string[] args)
    {
        string str = "Hello , World";
        string encoded = str.Encoder();
    Console.WriteLine(encoded); 

    string decoded = encoded.Decoder();
    Console.WriteLine(decoded);

    }

 
}
