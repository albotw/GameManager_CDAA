using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.sort
{
    /*
        * interface qui permet la comparaison par rapport à plusieurs champs.
        * crée car IComparable ne permet de préciser sur quel champ comparer.
    */
    public interface IFieldComparable<T>
    {
        int CompareFieldTo(Field field, T other);
    }
}
