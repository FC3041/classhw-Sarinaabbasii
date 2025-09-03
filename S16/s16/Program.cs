namespace s16;

class Program
{

    static void print_citizen(Citizen[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Teacher teacher1 = new Teacher("kane", "Dave", 1, 1000, 5, 11);
        Teacher teacher2 = new Teacher("Zari", "Hedayati", 2, 2000, 5, 21);
        Teacher teacher3 = new Teacher("Pari", "Hedayati", 3, 2500, 5, 31);
    
        Citizen[] citizens = new Citizen[]{teacher1, teacher2, teacher3};
        print_citizen(citizens);
    }
}
