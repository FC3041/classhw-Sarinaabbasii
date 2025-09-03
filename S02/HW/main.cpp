#include<iostream>
using namespace std;
#include<math.h>



class Point
{
    public:
        double x;
        double y;

        Point(double t , double r)
        {
            x = t;
            y = r;
        }
};


class Circle
{
    public:
        double x;
        double y;
        double r;

        Circle(double a , double b , double c)
        {
            x = a;
            y = b;
            r = c;
        }

        double circumference()
        {
            double result = 2 * r * M_PI;
            return result;
        }

        double area()
        {
            double result = r * r * M_PI;
            return result;
        }

        double center_distance(Circle c)
        {
            double x_diff = (x - c.x);
            double y_diff = (y - c.y);

            return sqrt(x_diff*x_diff + y_diff*y_diff);
        }

        double point(Point p)
        {
            double x_diff = (x - p.x);
            double y_diff = (y - p.y);

            if(sqrt(x_diff*x_diff + y_diff*y_diff)<r)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        double point_distance(Point p)
        {
            double x_diff = (x - p.x);
            double y_diff = (y - p.y);

            return sqrt(x_diff*x_diff + y_diff*y_diff);
        }
};

int main()
{
    Circle c1(0,0,2);
    Circle c2(3,4,1);
    Point p1(1,1);

    cout << "circumference : " << c1.circumference() << endl;
    cout << "area : " << c1.area() << endl;
    cout << "center distance : " <<  c1.center_distance(c2) << endl;
    cout << "point distance : "<< c1.point_distance(p1) << endl;
    if(c1.point(p1) == 0)
    {
        cout << "The point is outside the circle." << endl;
    }
    else
    {
        cout << "The point is inside the circle." << endl;   
    }

}
