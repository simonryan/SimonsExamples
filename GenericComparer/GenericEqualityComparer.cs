using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericComparer
{
    public interface IComparable
    {
        string PrimaryId { get; set; }
    }

    public class GenericEqualityComparer<T> : IEqualityComparer<T> where T : IComparable
    {
        public bool Equals(T x, T y)
        {
            return x.PrimaryId == y.PrimaryId;
        }

        public int GetHashCode(T obj)
        {
            return obj.PrimaryId.GetHashCode();
        }
    }
}
