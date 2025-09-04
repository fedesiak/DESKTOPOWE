#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main()
{

        int tab[10];
    int *wt;
    wt = &tab[0];  //adres tabeli

    srand(time(NULL));
    for(int i=0;i<10;i++){
    *wt=rand()%90+10;
    cout<<*wt<<endl;
    wt++;

    }
    cout<<endl;
    for(int i=0;i<10;i++){
        cout<<tab[i]<<endl;
    }
    cout<<endl;




    int *tab2 = new int[5];
    // new = alokacja pamieci

    for(int i =0;i<5;i++){
        tab2[i]=rand()%90+10;
        cout<<tab2[i]<<endl;

    }
    cout<<endl;
    delete [] tab2;
    //delete = zwolnienie pamieci

    for(int i =0;i<5;i++){
        cout<<tab2[i]<<endl;


    }

    int **tab3 = new tab3[6];  //tworzenie tablicy dwuwymiarowej   --- alokacja pamieci z tablicy po jednym elemencie do trzyelementowej
    for(int i = 0;i<5;i++){
        tab3[i] = new int[3];

    }

        for(int y=0;y<3;y++){
                tab3[i][y]=rand()%90+10;
        }



    return 0;
}
