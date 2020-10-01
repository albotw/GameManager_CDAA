using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core
{
    public interface IFieldComparable<T>
    {
        int CompareFieldTo(string field, T other);
    }
}
