using System;
using System.Numerics;

public interface IVector<T> where T : INumber<T>
{
    T Magnitude { get; set; }
    T Angle { get; set; }
    AngleVector<T> Add(IVector<T> o);
}

public class AngleVector<T> :
    IEquatable<AngleVector<T>>,
    IComparable<AngleVector<T>>,
    IVector<T>
    where T : INumber<T>
{
    public AngleVector(T r, T theta)
    {
        this.Magnitude = r;
        this.Angle = theta;
    }

    public T Magnitude { get; set; }
    public T Angle { get; set; }

    public int CompareTo(AngleVector<T> v) =>
        this.Magnitude.CompareTo(v.Magnitude);

    public AngleVector<T> Add(IVector<T> v)
    {
        
        double rad1 = double.CreateChecked(this.Angle) * Math.PI / 180;
        double rad2 = double.CreateChecked(v.Angle) * Math.PI / 180;

        double x1 = double.CreateChecked(this.Magnitude) * Math.Cos(rad1);
        double y1 = double.CreateChecked(this.Magnitude) * Math.Sin(rad1);

        double x2 = double.CreateChecked(v.Magnitude) * Math.Cos(rad2);
        double y2 = double.CreateChecked(v.Magnitude) * Math.Sin(rad2);

        double x = x1 + x2;
        double y = y1 + y2;

        double FinalMagnitude = Math.Sqrt(x * x + y * y);
        double FinalAngle = Math.Atan2(y, x) * 180 / Math.PI;

        return new AngleVector<T>(T.CreateChecked(FinalMagnitude),T.CreateChecked(FinalAngle));
    }

    public bool Equals(AngleVector<T> v)
    {
        if (v == null)
            return false;

        return this.Magnitude==v.Magnitude && this.Angle==v.Angle;
    }

    public override bool Equals(object obj)
    {        
        AngleVector<T> v = obj as AngleVector<T>;
        if (v != null)
            return Equals(v);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Angle.GetHashCode() ^ this.Magnitude.GetHashCode();
    }
}