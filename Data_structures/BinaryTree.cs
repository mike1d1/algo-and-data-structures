using System;

namespace Sorting 
{
    class BinaryTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int data, Node left = null, Node right = null)
            {
                this.data = data;
                this.left = left;
                this.right = right;
            }
        }

        public Node root = null;
        
        // Traversing tree using different techniques
        private void PreOrderTraversal(Node node)
        {
            if(node != null)
            {
                Console.WriteLine(node.data);
                PreOrderTraversal(node.left);
                PreOrderTraversal(node.right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        private void InOrderTraversal(Node node)
        {
            if(node != null)
            {
                InOrderTraversal(node.left);
                Console.WriteLine(node.data);
                InOrderTraversal(node.right);
            }
        }

        public void InOrderTraversal()
        {
            this.InOrderTraversal(root);
        }

        private void PostOrderTraversal(Node node)
        {
            if(node != null)
            {
                PostOrderTraversal(node.left);
                PostOrderTraversal(node.right);
                Console.WriteLine(node.data);
            }
        }

        public void PostOrderTraversal()
        {
            this.PostOrderTraversal(root);
        }


        private Node InsertFromNode(int data, Node node)
        {
            if(node == null)
            {
                return new Node(data);
            }
            if(data > node.data)
            {
                node.right = InsertFromNode(data, node.right);
            }
            else if(data < node.data)
            {
                node.left = InsertFromNode(data, node.left);
            }
            return node;
        }

        public Node Insert(int data)
        {
            if(this.root == null)
            {
                root = new Node(data);
                return root;
            }
            return InsertFromNode(data, root);
        }

        public Node Search(int data, Node node)
        {
            if(data == node.data || node == null)
            {
                return node;
            }

            if(data > node.data)
            {
                return Search(data, node.right);
            }
            else
            {
                return Search(data, node.left);
            }
        }

        public Node Minimum(Node node)
        {
            Node current = node;
            if(current == null)
                return null;
            while(current.left != null)
            {
                current = current.left;
            }
            return current;
        }

        public Node Maximum(Node node)
        {
            Node current = node;
            if(current == null)
                return null;
            while(current.right != null)
            {
                current = current.right;
            }
            return current;
        }

        public Node Parent(Node node)
        {
            if(node == root)
            {
                throw new ArgumentException("Node is a root node and hence has no parent node");
            }
            Node current = root;
            while(current.left != node && current.right != node && current!=null)
            {
                if(node.data < current.data)
                {
                    current = current.left;
                    continue;
                }
                else if(node.data > current.data)
                {
                    current = current.right;
                    continue;
                }
            }
            return current;
        }

        public Node Successor(Node node)
        {
            // If node has right subtree, the successor will be the node with minimum value in the right subtree
            if(node.right != null)
            {
                return Minimum(node.right);
            }
            // Otherwise move up the tree and find node that is the left child of its parent. Its parent is then a successor
            Node p = Parent(node);
            Node current = node;
            while(p != null && current == p.right)
            {
                current = p;
                p = Parent(p);
            }
            return p;
        }

        public Node Predecessor(Node node)
        {
            // If node has left subtree, the predecessor will be the node with maximum value in the left subtree
            if(node.left != null)
            {
                return Maximum(node.left);
            }
            // Otherwise move up the tree and find node that is the right child of its parent. Its parent is then a predecessor
            Node p = Parent(node);
            Node current = node;
            while(p != null && current == p.left)
            {
                current = p;
                p = Parent(p);
            }
            return p;
        }

        public void ReplaceNodeInParent(Node node, Node newValue=null) 
        {
            if(Parent(node) != null)
            {
                // If node is the left child of its parent,...
                if(node == Parent(node).left)
                {
                    // ...replace its left child with new value
                    Parent(node).left = newValue;
                }
                else if(node == Parent(node.right))
                {
                    Parent(node).right = newValue;
                }
            }
        }

        public void Delete(int value)
        {
            // Find the node to delete
            Node node = Search(value, root);
            if(node.left != null && node.right != null) // If both children are present
            {
                Node successor = Successor(node);
                node.data = successor.data;
                Delete(successor.data);
            }
            else if(node.left != null) // If node has only left child
            {
                ReplaceNodeInParent(node, node.left);
            }
            else if(node.right != null) // If node has only right child
            {
                ReplaceNodeInParent(node, node.right);
            }
            else // If node has no children
            {
                ReplaceNodeInParent(node);
            }
        }
    }
}
