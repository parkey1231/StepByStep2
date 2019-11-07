using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;


namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>();
            Tree<char> tree2 = new Tree<char>();
            Tree<double> tree3 = new Tree<double>();
            tree1.Insert(12);
            tree1.Insert(13);
            tree1.Insert(1);
            tree1.Insert(-9);
            tree1.Insert(-6);
            tree1.Insert(2);
            tree1.Insert(12);
            //====================
            tree2.Insert('a');
            tree2.Insert('n');
            tree2.Insert('c');
            tree2.Insert('l');
            tree2.Insert('y');
            tree2.Insert('q');
            tree2.Insert('b');

            tree3.Insert(12);
            tree3.Insert(13);
            tree3.Insert(1);
            tree3.Insert(-9);
            tree3.Insert(-6);
            tree3.Insert(2);
            tree3.Insert(12);

            string sort1 = tree1.WalkTree();
            string sort2 = tree2.WalkTree();
            string sort3 = tree3.WalkTree();
          

        }
    }
}
