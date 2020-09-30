using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core
{
    class QuickSort<T> where T : IComparable<T>
    {
        public void Sort(ref T[] tab, int gauche, int droite)
        {
            if (gauche >= droite)
            {
                return;
            }

            int p = Partition( ref tab, gauche, droite);
            
            Sort(ref tab, gauche, p);
            Sort(ref tab, p + 1, droite);
        }

        private int Partition(ref T[] tab, int gauche, int droite)
        {
            //on prend l'élément du milieu
            T pivot = tab[gauche + (droite - gauche) / 2];

            //on copie les limites du tableau comme des pointeurs.
            int cpy_gauche = gauche;    // = 0;
            int cpy_droite = droite;    // = Length (10);
            while(true)
            {
                //on cherche le 1er élément plus grand que le pivot à partir 
                while (pivot.CompareTo(tab[cpy_gauche]) > 0)
                {
                    cpy_gauche++;
                }

                //on cherche le 1er élément plus petit que le pivot à droite de celui ci
                while(pivot.CompareTo(tab[cpy_droite]) < 0)
                {
                    cpy_droite--;
                }

                //dans le cas ou tous les éléments sont bien placés par rapport au pivot, on retourne le pointeur de droite comme nouvelle limite du tableau
                if (cpy_gauche >= cpy_droite)
                {
                    return cpy_droite;
                }

                //on échange les deux éléments pour qu'ils soient en bonne position par rapport au pivot
                T tmp = tab[cpy_gauche];
                tab[cpy_gauche] = tab[cpy_droite];
                tab[cpy_droite] = tmp;

                //on réduit la recherche dans le tableau de 2 comme deux éléments viennent d'être bien placés
                cpy_gauche++;
                cpy_droite--;
            }
        }
    }
}
