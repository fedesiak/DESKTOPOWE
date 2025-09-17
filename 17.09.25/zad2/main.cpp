#include <iostream>

using namespace std;
struct Przedmiot{
    string nazwa;
    float cena;
    Przedmiot *next;
};

Przedmiot *usun(Przedmiot *glowa, string nazwaDoUsuniecia){
    Przedmiot *temp;
    temp->glowa;
    Przedmiot *poprzedni;
    while(temp!=NULL){
        if(temp->nazwa==nazwaDoUsuniecia){
            if(temp!=glowa){
                glowa = glowa->next;
                temp = temp->next;
                delete temp;

            }
            else{
                    poprzedni->next = temp->next;
                    temp = temp->next;
            delete temp;

            }

        }
        else{

        }
    }

}

int main()
{
    Przedmiot *head = NULL;
    Przedmiot *tail = NULL;
    char d;

    Przedmiot *nowy;
     do{
    nowy = new Przedmiot;
    cout << "Podaj nazwe przedmiotu" << endl;
    cin >> nowy->nazwa;
    cout << "Cena przedmiotu: "<<endl;
    cin >> nowy->cena;
    nowy->next= NULL;
    if(head==NULL){
        head = nowy;
        tail = nowy;
    }
    else{
    tail->next = nowy;
    tail = nowy;
    }

    cout << "Czy chcesz podac kolejny element do listy (t/n)" <<endl;
    cin >> d;
    }
    while(d=='t');
    cout << "lista przedmiotow:" <<endl;

    Przedmiot *temp =head;
    while(temp!=NULL)
    {
        cout << temp->nazwa << " cena "<<temp->cena << " zl "<<endl;
        temp=temp->next;

    }

    return 0;
}
