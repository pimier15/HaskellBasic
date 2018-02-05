using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskell2Cs
{
    class Program
    {
        static void Main( string[] args )
        {
			TreeTest.main();
			var temp = new List<int>();
			temp.Add( 1 );
			temp.Add( 2 );
			temp.Add( 3 );
			var res = GFold<int,int>.Foldr( ( f, s ) => f + s,0, temp );
			Console.Write( res );
			Console.ReadLine();
        }
    }
}
