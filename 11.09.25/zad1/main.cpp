#include <iostream>

using namespace std; //struktury dynamiczne wprowadzenie

struct Osoba{
    string nazwisko;
    int wiek;
    Osoba *nastepny;  //tworzymy wskaünik
};
int main()
{
    do{
    char decyzja;
    Osoba *head = NULL;  //glowa ma wartosc null tutaj
    Osoba *nowy;
    nowy = new Osoba;  //alokacja pamieci dla nowego elementu
    cout<<"Podaj nazwisko: "<<endl;
    cin>>nowy->nazwisko;
    cout<<"Podaj wiek: "<<endl;
    cin>>nowy->wiek;
    nowy->nastepny = NULL;
    head = nowy;
    cout<<"Czy chcesz wprowadzic jeszcze jeden element do listy? t/n "<<endl;
    cin>>decyzja;
    }
    while(decyzja=='t');
}



}
