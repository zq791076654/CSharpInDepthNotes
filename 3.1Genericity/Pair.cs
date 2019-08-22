using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1Genericity
{
    public class Pair<TFirst, TSecond> : IEquatable<Pair<TFirst, TSecond>>
    {
        public Pair(TFirst first, TSecond second)
        {
            this.first = first;
            this.second = second;
        }
        private readonly TFirst first;
        public TFirst First { get; }

        private readonly TSecond second;
        public TSecond Second { get; }

        private static readonly IEqualityComparer<TFirst> firstComparer = EqualityComparer<TFirst>.Default;
        private static readonly IEqualityComparer<TSecond> secondComparer = EqualityComparer<TSecond>.Default;

        public bool Equals(Pair<TFirst, TSecond> other)
        {
            return other != null &&
                firstComparer.Equals(this.First, other.First) &&
                secondComparer.Equals(this.Second, other.Second);
        }
    }
}
