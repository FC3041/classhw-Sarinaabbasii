#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }
    bool checkSubstr(const char* chars)
    {
        int temp;
        if(len(m_PChars)>len(chars))
        {
            for(int i=0;i<= (len(m_PChars)-len(chars));i++)
            {
                for (int j = 0;j<=len(chars) ; j++)
                {
                    temp = 0;
                    
                    if(m_PChars[i+j] == chars[j])
                    {
                        temp = 1;
                        for(int k =1;k<len(chars);k++)
                        {
                            if(m_PChars[i+j+k]!=chars[j+k])
                            {
                                temp = 0;
                            }
                        }
                        if(temp==1)
                            return true;       
                    }
                
                }
            }
            return false;
            
        }
        return false;
    }

    void len()
    {
        int i = 0;
        int count = 0;
        while(m_PChars[i]!='\0')
        {
            i++;
            count++;
        }
        cout << count << endl;
    }
    int len(const char* chars)
    {
        int i = 0;
        int count = 0;
        while(chars[i]!='\0')
        {
            i++;
            count++;
        }
        return count;
    }
    void add(const char* chars)
    {
        m_size = len(m_PChars) + len(chars) ;
        char* newMem = (char*)malloc(sizeof(char)*(m_size+1) );  
        int i;
        for(i=0; i<len(m_PChars);i++)
        {
            newMem[i] = m_PChars[i];     
        }
        for(int j=0;j<len(chars);j++)
        {
            newMem[i+j] = chars[j];
        }
        free(m_PChars);
        m_PChars = newMem;
        m_PChars[m_size] = '\0' ;
        cout << m_PChars << endl;

    }      
    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    void printStr()
    {
        cout << m_PChars << endl;
    }
};


int main()
{
    MyStr s1;

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();
    cout << s2.checkSubstr("sji")<< endl;
    s2.len();
    s2.add("malihe");  
    return 0;
    
}