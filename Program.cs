using System;

namespace Practice {

    public class Animal {
        public void eat () {
            Console.WriteLine ("Eatingggg");
        }
    }

    public class Dog : Animal {
        public void bark () {
            // Console.WriteLine ("Barkingggg");
            // eat ();
        }
    }
    class C {
        static void Main (string[] args) {
            // Animal a = new Animal ();
            // Dog d = new Dog ();
            // d.eat ();
            BinarySearchTree bst = new BinarySearchTree ();
            Node node = new Node ();
            bst.Insert (5);
            bst.Insert (3);
            bst.Insert (100);
            bst.Insert (90);
            bst.Insert (50);
            bst.Insert (77);
            bst.Display ();
            bst.Search(50);
        }
    }
}

public class Node {
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node () {

    }
    public Node (int data) {
        Data = data;
    }
}
public class BinarySearchTree {

    public Node data { get; set; }
    private Node _root;

    public void Insert (int data) {
        if (_root == null)
            _root = new Node (data);
        else InsertData (_root, new Node (data));
    }
    private void InsertData (Node root, Node newNode) {
        if (root == null)
            root = newNode;
        if (root.Data < newNode.Data) {
            if (root.Right == null)
                root.Right = newNode;
            else InsertData (root.Right, newNode);
        } else {
            if (root.Left == null)
                root.Left = newNode;
            else InsertData (root.Left, newNode);
        }
    }
    private void Display (Node root) {
        if (root == null)
            return;
        Display (root.Left);
        Console.WriteLine (root.Data);
        Display (root.Right);

    }
    public void Display () {
        this.Display (_root);
    }

    private Node Search(Node root,int data){
        if(root == null) return null;
        if(data > root.Data){
            if(data == root.Right.Data)
            return root;
            else return Search(root.Right,data);
        }
        else{
            if(data == root.Left.Data)
            return root;
            else return Search(root.Left,data);
        }
    }
    public void Search(int data){
          var result = Search(_root,data);
          Console.WriteLine("Node found at :"+result.Data);
    }
}