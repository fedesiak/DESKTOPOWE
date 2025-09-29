#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;         //    INF.04-01-22.06-SG niedokonczony
int rozmiar = 50;

/******************************************************
nazwa funkcji: wypelnij
argumenty: tab - przechowuje elementy tablicy
< nazwa argumentu> - <co przechowuje>
typ zwracany:
<nazwa typu>, <co jest zwracane>
informacje: wypisuje losowe elementy tablicy z zakresu 1-100
autor: <numer zdaj¹cego>
*****************************************************/
void wypelnij(int tab[]){
    srand(time(NULL));
    for(int i=0;i<rozmiar;i++){
        tab[i] = rand()%100+1;
    }
}

/******************************************************
znajdzIndex
argumenty:
tab - tablica liczb calkowitych
szukany - liczba calkowita, ktora szukamy w tablicy
typ zwracany:
int, indeks znalezionego elementu
informacje: jesli index jest rowny rozmiarowi tablicy to oznacza, ze szukanego elementu nie bylo w tablicy
autor: 00000000000
******************************************************/
int znajdzIndex(int tab[], int szukany){
    tab[rozmiar]=szukany;
    for(int i=0;i<=rozmiar;i++){
        if(tab[i]==szukany){
            return i;
        }
        else{}
    }
}

int main()
{
    int tab[rozmiar];
    wypelnij(tab);
    int szukanyElement;
    for(int i=0;i<50;i++){
        cout<<tab[i]<<", ";
    }
    cout<<"Podaj szukany element: "<<endl;
    znajdzIndex(tab, szukanyElement);
    return 0;
}
