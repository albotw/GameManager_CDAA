using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core
{
    public abstract class Field : IEquatable<Field>
    {
        protected Field(string value) { Value = value; }

        public string Value { get; set; }

        public bool Equals(Field other)
        {
            return Value.Equals(other.Value);
        }
    }
}
