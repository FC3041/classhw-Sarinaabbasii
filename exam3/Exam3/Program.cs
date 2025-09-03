using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Exam3;

// QS0-------------------------------------------------------------------------
public class Animal
{
    public virtual string MakeSound() { return "Some generic animal sound"; }
}
public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}


// QS1-------------------------------------------------------------------------

public class MyPointType1
{

    public int X { get; set; }
    public int Y { get; set; }

}
public struct MyPointType2
{

    public int X { get; set; }
    public int Y { get; set; }

}
public struct Product : IComparable<Product>
{

    public String Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(Product other)
    {
        return other.Price.CompareTo(this.Price);
    }
}


// QS2-------------------------------------------------------------------------

// public class Comparer<T> : IComparable<T>
// {
//     T T1;
//     T T2;

//     public Comparer(T v1, T v2)
//     {
//         this.T1 = v1;
//         this.T2 = v2;
//     }
//     public int Compare(string t1, string t2)
//     {
//         return t1.CompareTo(t2);
//     }
//     public int Compare(int t1, int t2)
//     {
//         return t1.CompareTo(t2);
//     }
//     public int Compare(Product p1, Product p2)
//     {
//         return p1.Price.CompareTo(p2.Price);
//     }
// }


// QS6-------------------------------------------------------------------------------------------------
public struct Money
{
    public int Amount { get; set; }
    public string s { get; set; }

    public Money(int v1, string v2)
    {
        Amount = v1;
        s = v2;
    }
    public bool Equals(Money m1)
    {
        if (m1.Amount == this.Amount && m1.s == this.s)
        {
            return true;
        }
        return false;
    }
    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Amount + m2.Amount, m1.s);
    }
    public static bool operator ==(Money m1, Money m2)
    {
        if (m1.Amount == m2.Amount && m1.s == m2.s)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Money m1, Money m2)
    {
        if (m1 == m2)
        {
            return false;
        }
        return true;
    }
}
public static class LinqProblems
{
    public static int Amount { get; private set; }

    public static IEnumerable<int> FilterAndDouble(List<int> numbers)
    {
        var n = numbers.Where(l => l > 5 && l % 2 == 0)
        .Select(l => { return l * 2; });
        return n;

    }
    public class Sale 
{
    public String Category { get; set; }
    public int Amount { get; set; }
}
}

public class ResourceManager : IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
