#include <iostream>

using namespace std;   //      -----wskazniki dwukierunkowe-----

struct Uczen{  //zadeklaruj strukture
    string imie;  //naucz sie tych deklaracji
    int wzrost;
    Uczen *next; //wskazniki
    Uczen *prev;

};

int main()
{
    Uczen *glowa;
    glowa=NULL; //  glowa = new Uczen();  -- alokacja pamieci dla glowa

   // glowa->next == NULL; //ustawiamy wskaznik na null
   // glowa->prev == NULL;

    Uczen *temp; //zmienna tymczasowa deklaracja

    Uczen *nowy;
      char decyzja;
    do{ //deklarujemy nowy wskaznik dla ucznia i alokacja pamieci dla nowy
    nowy = new Uczen;

    cout<<"Podaj imie: "<<endl;
    cin>>nowy->imie;

    cout<<"Podaj wzrost w cm: "<<endl;
    cin>>nowy->wzrost;

    nowy->next = NULL; //czyscimy wskaznik, podstawiamy null, w podstawieniu null ma jedno =

    if(glowa==NULL){  //jezeli glowa jest rowna zero
        glowa = nowy;  //nadajemy glowie nowa wartosc
    }
    else{              //w innym wypadku
        temp = glowa;  //podstawiamy temp pod glowe
        while(temp->next!=NULL){  //dopóki temp nie jest pusty
            temp=temp->next;     //przesuwamy temp o nastepne pole

        }
        temp->next = nowy;
        nowy->prev=temp;  //teraz zmienna w kierunku przeciwnym

    }
    cout<<"Czy chcesz wprowadzic nowy element do listy? t/n "<<endl;
    cin>>decyzja;
    }
    while(decyzja=='t');
    temp=glowa;

    while(temp != NULL){
        cout<<"imie: "<<temp->imie<<" wzrost: "<<temp->wzrost<<"cm"<<endl;
        temp=temp->next;
    }


    //   -----teraz wypisz tylko tych ktorzy sa wyzsi od sasiadow next i prev, ludzie na bokach sie nie licza-----
    cout<<endl<<"Ludzie wyzsi od sasiadow: "<<endl;
    temp = glowa->next;  //rozpoczynamy od drugiego elementu bo pierwszego nie liczymy
    temp->next!=NULL;   //nastepny temp nie moze sie rownac 0
    while(temp->next!=NULL){
    if((temp->wzrost>temp->next->wzrost)&&(temp->wzrost>temp->prev->wzrost)){  //warunek bycia wyzszym od sasiadow obok siebie

        cout<<"imie: "<<temp->imie<<" wzrost: "<<temp->wzrost<<"cm"<<endl;

    }
    temp = temp->next;  //przesuwamy element
    }





    return 0;
}

