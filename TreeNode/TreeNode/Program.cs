using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNodeTest
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value != null)
            {
                this.root = new TreeNode<T>(value);
            }
        }
    }

    public class TreeNode<T>
    {
        private T value;
        private bool hasParent;
        private List<TreeNode<>> children;

        public TreeNode(T value)
        {
            if (value != null)
            {
                this.value = value;
                this.children = new list<TreeNode<>>();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
