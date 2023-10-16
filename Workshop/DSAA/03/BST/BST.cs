using System;
using System.Collections.Generic;

namespace Algo; 

public class BST 
{
    private Node? root;

    public const int PREFIX = 1;
    public const int INFIX = 2;
    public const int POSTFIX = 3;

    public BST() 
    {
        root = null;
    }

    public bool Insert(Node node)
    {
        if (node == null) {
            // cannot insert null
            return false;
        }

        if (root == null) {
            // tree has no nodes yet, set this one as root
            root = node;
            return true;
        }

        return Insert(node, root);
    }

    private bool Insert(Node node, Node curr) 
    {
        if (node.key == curr.key) {
            return false;   // no duplicate keys allowed
        }

        if (node.key < curr.key) {                
            if (curr.left == null) {
                // found empty spot for new node
                curr.left = node;
                return true;
            }

            // go to left branch
            return Insert(node, curr.left);
        }
        else {  
            if (curr.right == null) {
                // found empty spot for new node
                curr.right = node;
                return true;
            }                

            // go to right branch
            return Insert(node, curr.right);
        }
    }

    public void DepthFirst(int mode) 
    {
        if (mode == PREFIX) {
            Prefix(root);
        }
        else if (mode == INFIX) {
            Infix(root);
        }
        else if (mode == POSTFIX) {
            Postfix(root);
        }

        // clear trailing "%" character
        Console.WriteLine("");
    }

    private void Prefix(Node? node) 
    {
        if (node == null) {
            return;
        }

        Console.Write("{0} ", node.key);
        Prefix(node.left);
        Prefix(node.right);
    }

    private void Infix(Node? node) 
    {
        if (node == null) {
            return;
        }

        Infix(node.left);
        Console.Write("{0} ", node.key);
        Infix(node.right);
    }

    private void Postfix(Node? node) 
    {
        if (node == null) {
            return;
        }

        Postfix(node.left);
        Postfix(node.right);
        Console.Write("{0} ", node.key);
    }

    public void BreadthFirst() 
    {
        List<Node> nodes = new List<Node>();

        if (root != null) {
            nodes.Add(root);
        }

        while (nodes.Count > 0) {
            Node node = nodes[0];
            Console.Write("{0} ", node.key);

            if (node.left != null) {
                nodes.Add(node.left);
            }
            if (node.right != null) {
                nodes.Add(node.right);
            }

            nodes.RemoveAt(0);
        }

        // clear trailing "%" character
        Console.WriteLine("");
    }

    public Node? RecursiveFind(int key)
    {
        return RecursiveFind(key, root);
    }
    private Node? RecursiveFind(int key, Node cur)
    {
        if (cur == null) return null;

        if(key > cur.key)
        {
            return RecursiveFind(key, cur.right);
        }
        else if(key < cur.key)
        {
            return RecursiveFind(key, cur.left);
        }
        else
        {
            return cur;
        }
    }

    public Node? IterativeFind(int key)
    {
        return IterativeFind(key, root);
    }
    private Node? IterativeFind(int key, Node cur)
    {
        if (cur == null) return null;

        List<Node> nodeQueue = new List<Node>();
        nodeQueue.Add(cur);

        while(nodeQueue.Count() != 0)
        {
            Node t = nodeQueue[0];
            if (t.key == key) return t;

            if(t.key < key)
            {
                nodeQueue.Add(t.right);
            }
            else if(t.key > key)
            {
                nodeQueue.Add(t.left);
            }

            nodeQueue.RemoveAt(0);
        }

        return null;
    }
}






















