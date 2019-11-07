using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        private Tree<TItem> currentData = null;
        private TItem currentItem = default(TItem);
        private Queue<TItem> enumData = null;

        public TreeEnumerator(Tree<TItem> data)
        {
            this.currentData = data;
        }

        private void Populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if (tree.LeftTree != null)
            {
                Populate(enumQueue, tree.LeftTree);
            }

            enumQueue.Enqueue(tree.NodeData);

            if (tree.RightTree != null)
            {
                Populate(enumQueue, tree.RightTree);
            }
        }

        TItem IEnumerator<TItem>.Current
        {
            get
            {
                if (this.enumData == null)
                {
                    throw new InvalidOperationException("");

                }

                return this.currentItem;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
           // throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if ( this.enumData == null)
            {
                this.enumData = new Queue<TItem>();
                Populate(this.enumData, this.currentData);
            }

            if (this.enumData.Count > 0)
            {
                this.currentItem = this.enumData.Dequeue();
                return true;
            }

            return false;
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
