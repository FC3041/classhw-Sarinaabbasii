
public interface Vehicles
{
    public double Area();
    public double EngineCapacity();
    public int SeatingCapacity();
    public double TopSpeed();
}
class Car:Vehicles
{
    public double L;
    public double W;
    public int NumberOfCylindders;
    public double CylinddersCapacity;
    public Car(double ll, double ww , int N , double C)
    {
        L = ll;
        W = ww;
        NumberOfCylindders = N;
        CylinddersCapacity = C;
    }

    public double Area()
    {
        return L*W;
    }

    public double TopSpeed()
    {
        return 180;
    }
    public int SeatingCapacity()
    {
        return 4;
    }
    public double EngineCapacity()
    {
        return  NumberOfCylindders*CylinddersCapacity;
    }
};

class MotorCycle:Vehicles
{
    public double L;
    public double W;
    public int NumberOfCylindders;
    public double CylinddersCapacity;
    public MotorCycle(double ll, double ww , int N , double C)
    {
        L = ll;
        W = ww;
        NumberOfCylindders = N;
        CylinddersCapacity = C;
    }

    public double Area()
    {
        return L*W;
    }

    public double TopSpeed()
    {
        return 180;
    }
    public int SeatingCapacity()
    {
        return 2;
    }
    public double EngineCapacity()
    {
        return  NumberOfCylindders*CylinddersCapacity;
    }
}
class Truck:Vehicles
{
    public double L;
    public double W;
    public int NumberOfCylindders;
    public double CylinddersCapacity;
    public Truck(double ll, double ww , int N , double C)
    {
        L = ll;
        W = ww;
        NumberOfCylindders = N;
        CylinddersCapacity = C;
    }

    public double Area()
    {
        return L*W;
    }

    public double TopSpeed()
    {
        return 100;
    }
    public int SeatingCapacity()
    {
        return 2;
    }
    public double EngineCapacity()
    {
        return  NumberOfCylindders*CylinddersCapacity;
    }
}