#include <iostream>

using namespace std;
//                                            ---WSKAZNIKI---
//          wskaznik = adres
int main()
{
    int a;
    a=8;


    int *w;
    w = &a;
    cout<<a<<endl; //komorka a
    cout<<w<<endl; //adres komórki a
    cout<<*w<<endl<<endl;; //przypisany adres, wartosc 8



    *w = 24;
    cout<<a<<endl; //zmieniona komorka a
    cout<<w<<endl; //adres komórki a
    cout<<*w<<endl<<endl; //przypisany adres, zmieniona wartosc 24


//    dodanie wskaznikow
    int b = 16;
    int *w1;
    w1 = &b;

    cout<<*w+*w1<<endl<<endl;;

    //zmiana zawartosci wskaznika przez wartosc zmiennej

    a=55;
    cout<<*w<<endl<<endl;












    return 0;
}
