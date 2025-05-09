#include<iostream>
#include<string>
#include<vector>
using namespace std;


class String
{
    public:
        char* m_str;
        int m_capacity;

        String(string s)
        {   
            m_capacity = Size(s)+1;
            m_str = (char*)malloc(sizeof(char)*m_capacity);
            int i = 0;
            while (s[i]!='\0')
            {
                m_str[i] = s[i];
                i++;   
            }
            m_str[i] = '\0';
            cout << m_str << endl;
        }
        String(){}
        ~String()
        {
            if (m_str != nullptr)
            {
                free(m_str);
                m_str = nullptr;
            }
        }
        void assign(string newname)
        {   if(Size(newname)<m_capacity)
            {
                int i = 0;
                while (newname[i]!='\0')
                {
                    m_str[i] = newname[i];
                    i++;   
                }         
                m_str[i] = '\0';
                cout << m_str << endl;                
            }
            else
            {
                m_capacity *= 2;
                free(m_str);
                m_str = (char*)malloc(sizeof(char)*m_capacity);

                int i = 0;
                while (newname[i]!='\0')
                {
                    m_str[i] = newname[i];
                    i++;   
                }         
                m_str[i] = '\0';
                cout << m_str << endl; 

            }
        }
        int Size(string s)
        {
            int count = 0;
            int i = 0;
            while (s[i]!='\0')
            {
                i++; 
                count++;
            }            
            return count;
        }
        char* c_str()
        {
            return m_str;
        }
        void append(string a)
        {
            int size = Size(m_str) + Size(a) ;
            char* newMem = (char*)malloc(sizeof(char)*(size+1) );  
            int i;
            for(i=0; i<Size(m_str);i++)
            {
                newMem[i] = m_str[i];     
            }
            for(int j=0;j<Size(a);j++)
            {
                newMem[i+j] = a[j];
            }
            free(m_str);
            m_str = newMem;
            m_str[size] = '\0' ;
            cout << m_str << endl;

        }      
};



class  Vector
{
    public:

        int* m_vector;
        int m_size;
        int m_capacity;

        Vector(vector<int> vector_int , int size , int capacity)
        :m_size(size) , m_capacity(capacity)
        {
            m_vector = (int*)malloc(sizeof(int)*m_capacity);
            for(int i=0 ;i<m_size ;i++)
            {
                m_vector[i] = vector_int[i];
                
            }
   
        }
        ~Vector()
        {
            if (m_vector != nullptr)
            {
                free(m_vector);
                m_vector = nullptr;
            }          
        }
        void Push_back(int n)
        {
            if(m_capacity<=m_size)
            {
                m_capacity *= 2;
                m_size++;
                int* newmwm = (int*)malloc(sizeof(int)*m_capacity);
                for(int i=0 ;i<(m_size-1) ;i++)
                {
                    newmwm[i] = m_vector[i];
                }
                free(m_vector);
                m_vector = newmwm;
                m_vector[m_size-1] = n;
                Print();
            }
            else 
            {
                m_size++;
                m_vector[m_size-1] = n;
                Print();
            }
        }
        int Size()
        {
            return m_size;
        }
    
        int at(int n)
        {
            return m_vector[n];
        }
        void insert(int a , int b)
        {
            if(m_capacity<=m_size)
            {
                m_capacity *= 2;
                m_size++;
                int* newmwm = (int*)malloc(sizeof(int)*m_capacity);
                for(int i=0 ;i<(a) ;i++)
                {
                    newmwm[i] = m_vector[i];
                }
                newmwm[a] = b;
                for(int i = (a+1) ; i<m_size;i++)
                {
                    newmwm[i] = m_vector[i];
                }
                free(m_vector);
                m_vector = newmwm;
                Print();
            }  
            else
            {
                m_size++;
                for(int i = (m_size-1) ; i>a ;i--)
                {
                    m_vector[i] = m_vector[i-1];
                }      
                m_vector[a] = b;
                Print()       ;
            }
        }

        void erase(int n)
        {

            for(int i = n ; i<(m_size-1);i++)
            {
                m_vector[i] = m_vector[i+1];
            }
            m_size--;
            Print();
        }

        int capacity()
        {
            return m_capacity;
        }

        void clear()
        {
            m_size = 0;
            Print();
        }
        void Print()
        {
        
            if (m_size<1)
            {
                cout << "nums = {}"  << endl;       
            }
            else
            {
                int i;
                cout << "nums = {";
                for(i = 0; i<(m_size-1);i++)
                {
                    cout << m_vector[i] << ",";
                }
                cout << m_vector[m_size-1] << "}" << endl;
            }

        }
};


int main()
{
    string name("sarina");
    string name2;
    name2.assign("mozhdeh");
    cout << name.c_str() << ":" << name.size() << endl;
    name.append(" + "); 
    name.append(name2);
    name.append("\n");
    cout << name.c_str() << endl;

    vector<int> m = {1,2,3};
    Vector nums(m,3,3);
    nums.Push_back(14);
    for(int i=0; i<nums.Size(); i++)  
        cout << nums.at(i) << endl; 
    nums.insert(2,5);
    nums.erase(2);
    nums.capacity();
    nums.clear();


    return 0;
    
}

