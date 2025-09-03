#include<iostream>
#include<string>
#include<stdio.h>
#include<Windows.h>
using namespace std;



class KeepTime 
{
    unsigned long long StartTime;
    unsigned long long EndTime;
    
    public:
         
        KeepTime(string str)
        {
            cout << str << " = ";
            StartTime = GetTickCount64();
        }
    
        void TotalTime()
        {
            EndTime = GetTickCount64();
            cout << EndTime - StartTime << endl;
        }
};
    
int main()
{

        KeepTime t("for loop 365*5000000 double mul");
        double d = 1;
        for(int i=0; i<365*5000000; i++)
            d = d * 1.01;
        t.TotalTime();
        return 0;

}
