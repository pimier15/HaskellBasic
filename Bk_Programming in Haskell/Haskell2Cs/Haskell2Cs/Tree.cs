using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Haskell2Cs
{
	public interface Tree<T> where T : struct, IComparable<T>
	{ }

    public class EmptyTree<T> : Tree<T> where T : struct, IComparable<T>
	{
        
    }

    public class Node<T> : Tree<T> where T : struct, IComparable<T>
	{
        public T Op { get; set; }
        public Tree<T> Left { get; set; }
        public Tree<T> Right { get; set; }

        public Node( T op, Tree<T> l, Tree<T> r )
        {
            Op = op;
            Left = l;
            Right = r;
        }
    }

    public static class TreeExt
    {
        public static Tree<T> ToNode<T>(
            this T a,
            Tree<T> left,
            Tree<T> right)
			where T : struct, IComparable<T>
			=>
                new Node<T>(a, left, right);

        public static Tree<T> EndNode<T>(
            this T a )
			where T : struct, IComparable<T>
			=>
                new Node<T>( a , new EmptyTree<T>() , new EmptyTree<T>() );
    }

	public static class TreeMethod
	{
		public static Tree<T> InsertTree<T>( T x , Tree<T> node )  where T :struct , IComparable<T>
		{
			var empty = node as EmptyTree<T>;
			var nod = node as Node<T>;

			return nod == null ? x.EndNode() :
				   x.Equals( nod.Op ) ? x.ToNode( nod.Left, nod.Right ) :
				   x.CompareTo( nod.Op ) < 0 ? nod.Op.ToNode( InsertTree(  x , nod.Left ), nod.Right ) :
											   nod.Op.ToNode( nod.Left, InsertTree( x , nod.Right ) ) ; 
		}
	}

    public static class TreeTest
    {
		public static void main()
		{
			int[] list = new int[]{ 4,5,1};

			var numtree = GFold<int,Tree<int>>.Foldr( TreeMethod.InsertTree , new EmptyTree<int>() , list );

		}
    }

  

}
