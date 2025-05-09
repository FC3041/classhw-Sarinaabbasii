using System.Globalization;

namespace S12;

class Program
{


    static void Main(string[] args)
    {

        Vehicles[] vehicles = new Vehicles[]{
            new Car(2.5,6,4,1800),
            new MotorCycle(2,0.7,2,125),
            new Truck(8.5,2.5,8,10000)
        };
        double Area_sum = 0;
        double SeatingCapacity_sum = 0;

        for(int i=0; i<vehicles.Length;i++)
        {
            SeatingCapacity_sum += vehicles[i].SeatingCapacity();
            Area_sum += vehicles[i].Area();
        }
        System.Console.WriteLine(Area_sum);
        System.Console.WriteLine(SeatingCapacity_sum);
    }

}

