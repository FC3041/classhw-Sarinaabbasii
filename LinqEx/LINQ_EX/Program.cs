namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Query 1           
        Console.WriteLine("Query 1");

        var data = File.ReadAllLines("data.csv")
                            .Skip(1)
                            .Where(l=>l.ToLower().Contains("iran") && l.ToLower().Contains("at birth") && l.ToLower().Contains("both"))
                            .Select(l=>Data.Parse(l))
                            .OrderBy(t => t.Value)
                            .ToList();
                            data.ForEach(t=>System.Console.WriteLine(t));

        Console.WriteLine();


        //Query 2
        Console.WriteLine("Query 2");

                            double min = data.Min(d => d.Value);
                            double max = data.Max(d => d.Value);
                            double maxdiff = Math.Round( max-min , 2 );
                            System.Console.WriteLine(maxdiff);

        Console.WriteLine();

        
        //Query 3
        Console.WriteLine("Query 3");
        
        var data1 = File.ReadAllLines("data.csv")
                            .Skip(1)
                            .Where(l=>l.ToLower().Contains("at birth") && l.ToLower().Contains("both"))
                            .Select(l=>Data.Parse(l))
                            .GroupBy(t=>t.Country)
                            .Select(g=>
                            {
                                var minItem = g.OrderBy(x => x.Value).First();
                                var maxValue = g.Max(x => x.Value);
                                var diff = Math.Round(maxValue - minItem.Value,2);
                                return (g.Key , minItem.Year , minItem.Value , diff);
                            })
                            .OrderByDescending(x => x.diff)
                            .ToList();
                            int i = 0;
                            data1.ForEach(t=>{
                            
                                i++;
                                System.Console.Write(i);
                                System.Console.WriteLine(t);});

        Console.WriteLine();

    
        //Query 4
        Console.WriteLine("Query 4");

        var maleData = File.ReadAllLines("data.csv")
                            .Where(l=>l.ToLower().Contains(",male") && l.ToLower().Contains("at birth"))
                            .Select(l => Data.Parse(l))
                            .ToList();

        var femaleData =  File.ReadAllLines("data.csv")
                            .Where(l=>l.ToLower().Contains("female") && l.ToLower().Contains("at birth"))
                            .Select(l => Data.Parse(l))
                            .ToList();

        var result = maleData.Join(femaleData,
                                    (m) => ( m.Country, m.Year ),
                                    (f) => ( f.Country, f.Year ),
                                (m, f) =>(Country : m.Country,Year : m.Year,MLife : m.Value,FLife : f.Value, Diff : Math.Round(Math.Abs(f.Value - m.Value) , 2))
        )
                                .GroupBy(t => t.Country)
                                .Select(g =>
                                {
                                var maxdiff = g.OrderByDescending(t => t.Diff).First();
                                return 
                                (Country : maxdiff.Country, Diff : maxdiff.Diff);
                                })
                                .OrderByDescending(x => x.Diff)
                                .ToList();
                                int j = 0;
                                result.ForEach(t=>{
                                j++;
                                System.Console.Write(j);
                                System.Console.WriteLine(t);});
    }
}

