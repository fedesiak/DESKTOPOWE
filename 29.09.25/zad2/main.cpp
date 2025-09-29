#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;   //     INF.04-02-23.06-SG
int rozmiar=100;

void sortowanie(int tab[]){
    int temp;
    for(int i=0;i<rozmiar;i++){
        for(int j=0;j<rozmiar;j++){
            if(tab[j]>tab[j+1]){
                    temp =tab[j];
                    tab[j]=tab[j+1];
                    tab[j+1]=temp;
            }
        }
    }
}

int main()
{
    int tab[rozmiar];
    srand(time(NULL));

    cout<<"tablica przed sortowaniem: "<<endl;
    for(int i=0;i<rozmiar;i++){
        tab[i]=rand()%1001;
        cout<<tab[i]<<", ";
    }
    cout<<endl<<endl;

    cout<<"tablica po sortowaniu: "<<endl;
    sortowanie(tab);
    for(int i=0;i<rozmiar;i++){
        cout<<tab[i]<<", ";
    }

    return 0;
}
