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

        public override bool Equals(object obj)
        {
            return Value.Equals((obj as Field).Value);
        }

        public static bool operator== (Field f1, Field f2)
        {
            return f1 is null ? f2 is null : f1.Equals(f2);
        }

        public static bool operator!=(Field f1, Field f2)
        {
            return !(f1 == f2);
        }
    }
}
