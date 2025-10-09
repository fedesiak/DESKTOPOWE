#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

void wypelnijTablice(int iloscWierszy, int **tab)
{
    srand(time(NULL));
    for(int i=0; i<iloscWierszy; i++)
        {
            for(int j=0; j<6; j++)
                {
                    tab[i][j] = rand()%49+1;
                }
        }

}

int wypiszTablice(int **tab, int iloscWierszy)
                  {
                      for(int i = 0; i<iloscWierszy;i++)
                      {
                          cout<<"Losowanie "<<i+1<<": ";
                          for(int j=0; j<6; j++)
                          {
                              cout<<tab[i][j]<<" ";

                          }
                          cout<<endl;

                      }
                  }

int main()
{
    int iloscLosowan;
    cout<<"Podaj ilosc losowan: "<<endl;
    cin>>iloscLosowan;
    int **tab = new int*[iloscLosowan];
    for(int i=0; i<iloscLosowan;i++)
        {
            tab[i] = new int[6];
        }
    wypelnijTablice(iloscLosowan, tab);
    wypiszTablice(tab, iloscLosowan);
    int z=0;
    for(int j=1; j<50; j++)
        {
            for(int k=0; k<iloscLosowan; k++)
                {
                    for(int l=0; l<6; l++)
                    {
                        if(tab[k][l] == j)
                        {
                            z++;

                        }

                    }
                }
                cout<<"Wystapienia liczby: "<<j<<": "<<z<<endl;
        }

    return 0;
}
