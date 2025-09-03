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
        }

        void Start()
        {
            StartTime = GetTickCount64();
        }
        
        void Stop()
        {
            EndTime = GetTickCount64();
        }
    
        void TotalTime()
        {
            cout << EndTime - StartTime << endl;
        }
};
    
int main()
{

        KeepTime t("for loop 365*5000000 double mul");
        t.Start();
        double d = 1;
        for(int i=0; i<365*5000000; i++)
            d = d * 1.01;
        t.Stop();
        t.TotalTime();
        return 0;

}
