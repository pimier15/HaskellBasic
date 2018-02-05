using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskell2Cs
{
    public static class Fold
    {
        public static int Foldl( Func<int, int, int> func , int first ,List<int> xs )
        {
            if ( xs.Count() == 0 ) return first;
            return Foldl(func, func( first, xs[0] ), xs.Skip(1).ToList());
        }

		public static int Foldr( Func<int, int, int> func, int last, List<int> xs )
		{
			if ( xs.Count() == 0 ) return last;
			return func( xs.First(), Foldr( func, last, xs.Skip( 1 ).ToList() )) ;
		}

    }

	public static class GFold<A, B>
	{
		// Foldl을 사용하면 먼저 식을 계산하고, 그 결과를 넘겨서 새로운 식을 만들기 때문에, 스택 오버플로우가 안일어 난다. 
		public static B Foldl( Func<B, A, B> func, B first, IEnumerable<A> xs )
		{
			if ( xs.Count() == 0 ) return first;
			return Foldl( func, func( first, xs.First() ), xs.Skip( 1 ) );
		}

		public static B Foldr( Func<A, B, B> func, B last, IEnumerable<A> xs )
		{
			if ( xs.Count() == 0 ) return last;
			return func( xs.First(), Foldr( func, last, xs.Skip( 1 ) ) );
		}

	}
}
