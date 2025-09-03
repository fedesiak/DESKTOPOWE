#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

int main()
{
    int tab[10];
    int *wt;
    wt = &tab[0];

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

    return 0;
}
