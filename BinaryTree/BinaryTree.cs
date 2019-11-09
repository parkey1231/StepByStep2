using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree
{
    public class Tree<TItem> : IEnumerable<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { set; get; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }
       // public Tree<TItem> WholeTree = new Tree<TItem>();

        public Tree()
        {

        }

        public Tree(TItem newItem)
        {
            this.NodeData = newItem;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(TItem newItem)
        {
            TItem currentNodeData = this.NodeData;

            if (currentNodeData.CompareTo(newItem) > 0)
            {
                //Insert left sub-tree
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                    
                }
                else
                    //递归调用
                    this.LeftTree.Insert(newItem);
            }
            else
            {
                //Insert right sub-tree
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);

                }
                else
                    //递归调用
                    this.RightTree.Insert(newItem);

            }
        }

        public static void Insert(Tree<TItem> tree, params TItem[] data)  
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

        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
            {
                //递归调用
                result = this.LeftTree.WalkTree();
            }

            result += $" {this.NodeData.ToString()}";

            if (this.RightTree != null)
            {
                //递归调用
                result += this.RightTree.WalkTree();
            }

            return result;
        }

        IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
        {
            //return new TreeEnumerator<TItem>(this);
            if (this.LeftTree != null)
            {
                foreach (TItem item in this.LeftTree)
                {
                    yield return item;
                }
            }

            yield return this.NodeData;

            if(this.RightTree != null)
            {
                foreach (TItem item in this.RightTree)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
