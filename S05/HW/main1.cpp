#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int* m_Pnums;
        int m_capacity;

    MyList(int size, int *nums , int capacity)
    :m_size(size) , m_capacity(capacity)
    {
        m_Pnums = (int*)malloc(sizeof(int)*m_capacity);
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }

    void append(int n)
    {   if(m_capacity <= m_size)
        {
            m_capacity *= 2;
            m_size += 1;
            int* newMem = (int*)malloc(sizeof(int)*(m_capacity));  
            int i;
            for(i=0; i<m_size;i++)
            {
                newMem[i] = m_Pnums[i];     
            }
            free(m_Pnums);
            m_Pnums = newMem;
            m_Pnums[m_size-1] = n;
            print();
        }
        else
        {
            m_Pnums[m_size] = n;
            m_size++;
        }
    }

    void pop()
    {
        m_size -= 1;
        int* newMem = (int*)malloc(sizeof(int)*(m_size));  
        int i;
        for(i=0; i<m_size;i++)
        {
            newMem[i] = m_Pnums[i];     
        }
        free(m_Pnums);
        m_Pnums = newMem;
        print();
    }

    void count(int n)
    {
        int count = 0;
        for(int i=0; i<m_size;i++)
        {
            if(m_Pnums[i]==n)
            {
                count += 1;
            }     
        }
        cout << count << endl;      
    }

    void print()
    {
        int i;
        cout << "nums = {";
        for(i=0; i<(m_size-1);i++)
        {
            cout << m_Pnums[i] << ",";     
        }
        cout << m_Pnums[i] << "}" << endl;
    }
};

int main()
{
    int nums[5];
    nums[0]=1;
    nums[1]=2;
    MyList m(2, nums,5);
    m.append(14);
    m.pop();
    m.count(2);
    m.print();
}