using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskell2Cs
{
	public interface YesNo<A>
	{
		bool yesno( A a );
	}

	public class IntYesNo : YesNo<int>
	{
		public bool yesno( int a )
		{
			return a == 0 ? false : true;
		}
	}

	public class MaybeYesNo<A> : YesNo<Maybe<A>>
	{
		public bool yesno( Maybe<A> a )
		{
			var obj = a as Nothing<A>;
			return obj == null ? true : false;
		}
	}

	

	public class YesNoExt
	{
		public static A yesnoIf<A, B>(
			this A src,
			B yes,
			B no )
		{
			return src.yesno()
		}

	}

	class TypeClass 
	{
	}


	public interface Maybe<T> { }

	public class Just<A> : Maybe<A>
	{
		public A Value;
	}

	public class Nothing<A> : Maybe<A>
	{

	}


}
