#include <iostream>
#include <string>

//������� ������ �36�

//� ���� ������ �������.
//1. ��� ����� operator>> � operator<< ������� � �����, ��� ��� ����� ��� ����, ��� �� ���������� str ���� � private
//2. ��� ������� ��� ��� �� ����� ���� ��������� � ����� str (���������� �������) ����� operator[]
//3. ��� ������� ��� ��� �� ����� ���� �������
//  std::string s="1234567890\n";
//  Myclass a=s;
//  �������� ���
//  Myclass a="1234567890\n";
//4. � �������� ������, �� � operator[], ��� ������� ��� ��� �� � ���������� ����� ����� ���� ����� ������� �����, � �� �������� ��������� ����������

class Myclass
{
private:
    //� ����� �� ��� �� str ���������� ��� ��� ���� ��� �� � ������ ���� ������������ ������, ������ ������ ������
public:
    std::string str;

    Myclass(){}
    Myclass (std::string s)
    {
        str=s;
    }

    char& operator[] (int &a)
    {
        return str[a];
    }
};

std::istream& operator>> (std::istream &is, Myclass &n)
{
    is >> n.str;
    return is;
}

std::ostream& operator<< (std::ostream &os, Myclass &n)
{
    os << n.str;
    return os;
}


int main()
{
    std::string s="1234567890\n";
    Myclass a=s;
    //� ���� ���
    //Myclass a="1234567890\n";

    int i=0; //��� ��� ����� ���������� �� ���������� i, � ���� �������� � char c
    std::cout<<a;
    std::cin>>a;
    char c=a[i];
    std::cout<<a<<' '<<c;
    return 0;
}
