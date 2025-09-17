#include <iostream>

using namespace std; //struktury dynamiczne wprowadzenie

struct Osoba{
    string nazwisko;
    int wiek;
    Osoba *nastepny;  //tworzymy wskaünik
};
int main()
{

    char decyzja;
    Osoba *head = NULL;  //glowa ma wartosc null tutaj, aby byla na poczatku pusta

    Osoba *nowy;
     do{
    nowy = new Osoba;  //alokacja pamieci dla nowego elementu
    cout<<"Podaj nazwisko: "<<endl;
    cin>>nowy->nazwisko;
    cout<<"Podaj wiek: "<<endl;
    cin>>nowy->wiek;
    nowy->nastepny = head;
    head = nowy;
    cout<<"Czy chcesz wprowadzic jeszcze jeden element do listy? t/n "<<endl;
    cin>>decyzja;
    }
    while(decyzja=='t');

    cout<<"Otrzymana lista: "<<endl;
    Osoba *temp = head;

    while(temp!=NULL){
        cout<<temp->nazwisko<<" "<<temp->wiek<<endl;
        temp=temp->nastepny; //wskazujemy na nastepny element
    }
}




