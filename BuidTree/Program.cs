using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BuidTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tree<int> tree1 = new Tree<int>();
            tree1.Insert(9);
            tree1.Insert(12);
            tree1.Insert(13);
            tree1.Insert(1);
            tree1.Insert(-9);
            tree1.Insert(-6);
            tree1.Insert(2);
            tree1.Insert(12);
            //InsertIntoTree(ref tree1, 102, 32, 1111, 34, 2, -1);
            Tree<int>.Insert(tree1, 102, 32, 1111, 34, 2, -1);
            string sort = tree1.WalkTree();
            Console.WriteLine(sort);
            */

            Console.WriteLine(Me('a'));

        }

        static void InsertIntoTree<TItem>(ref Tree<TItem> tree, params TItem[] data) where TItem : IComparable<TItem>
        {
            foreach (TItem datum in data)
            {
                if (tree == null)
                {
                    tree = new Tree<TItem>(datum);
                }
                else
                {
                    tree.Insert(datum);
                }
            }
        }

        static T Me<T>(T a)
        {
            T result = a ;
            return result;
        }
    }
}
