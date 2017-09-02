using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haskell2Cs
{
    public interface Tree<T> { }

    public class EmptyTree<T> : Tree<T>
    {
        
    }

    public class Node<T> : Tree<T>
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
            Tree<T> right) =>
                new Node<T>(a, left, right);


        public static Tree<T> Singleton<T>(
            this T a ) =>
                new EmptyTree<T>();



    }




    class Tree
    {
    }

    public class TreeNet
    {


    }

}
