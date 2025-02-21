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
            cout << "x in c:" << x << ", y in c:" << y << endl;
        }

        // Point(Point* b)
        // {
        //     x = b->x;
        //     y = b->y;
        // }

        Point(const Point& b)
        {
            x = b.x;
            y = b.y;
        }

        void print_point()

        {
            cout << "x:" << x << "y:" << y << endl; 
        }

        double points_distance(Point b)
        {
            double x_diff = (x - b.x);
            double y_diff = (y - b.y);

            return sqrt(x_diff*x_diff + y_diff*y_diff);
        }

        ~Point()
        {
            cout << "x in d:" << x << ", y in d:" << y << endl;
        }
};

// void print_point(Point p)
// {
//     cout << "x:" << p.x << "y:" << p.y << endl; 
// }

// double points_distance(Point a , Point b)
// {
//     double x_diff = (a.x - b.x);
//     double y_diff = (a.y - b.y);

//     return sqrt(x_diff*x_diff + y_diff*y_diff);
// }


int main()
{
    Point p1(1,1);
    int c = 5;
    if(c>3)
    {
        Point p2(2,2);
    }
    else
    {
        Point p3(3,3);
    }
}

int main()
{
    // Point p1;
    // p1.x = 3;
    // p1.y = 2;
    Point p1(4,5);
    p1.print_point();

    // Point p2;
    // p2.x = 4;
    // p2.y = 5;
    Point p2(3,2);

    p2.print_point();

    int a ;
    cin>>a;
    cout<<"a:" <<a<<endl;

    double d = p1.points_distance(p1);
    cout<<"distance:"<< d << endl;
}