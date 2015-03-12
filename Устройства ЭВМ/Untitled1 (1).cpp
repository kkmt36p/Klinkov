#include <iostream>
#include <string>

// линков Ќикита к36п

//” мен€ четыри вопроса.
//1.  ак можно operator>> и operator<< занести в класс, мне это нужно дл€ того, что бы переменна€ str была в private
//2.  ак сделать так что бы можно было обратитс€ к части str (отдельному символу) через operator[]
//3.  ак сделать так что бы можно было заместо
//  std::string s="1234567890\n";
//  Myclass a=s;
//  написать так
//  Myclass a="1234567890\n";
//4. » подобный вопрос, но с operator[], как сделать так что бы в квадратные скопи можно было сразу вводить число, а не заносить отдельную переменную

class Myclass
{
private:
    //я хотел бы что бы str находилась тут дл€ того что бы еЄ нельз€ было использовать внешне, только внутри класса
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
    //ј надо так
    //Myclass a="1234567890\n";

    int i=0; //“ут мне нужно избавитьс€ от переменной i, а ноль записать в char c
    std::cout<<a;
    std::cin>>a;
    char c=a[i];
    std::cout<<a<<' '<<c;
    return 0;
}
