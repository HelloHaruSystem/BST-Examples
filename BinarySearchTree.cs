public class BinarySearchTree<T> where T : IComparable<T>
{   
    // Internal class Node
    public class Node
    {
        public T value { get; set; }
        public Node? Left;
        public Node? Right;

        public Node(T value) 
        {
            this.value = value;
            this.Left = null;
            this.Right = null;
        }
    }

    public Node? Root { get; set; }
    public int Size { get; set; }

    public BinarySearchTree()
    {
        this.Root = null;
        this.Size = 0;
    }

    // this version 
    public void InsertIterative(T value)
    {
        if (this.Root == null)
        {
            this.Root = new Node(value);
            this.Size += 1;
            return;
        }

        Node? current = this.Root;
        
        // while current is not
        while (current != null)
        {   
            // if less than current
            if (value.CompareTo(current.value) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = new Node(value);
                    this.Size += 1;
                    return;
                } 
                else
                {
                    current = current.Left;
                }
            }
            // higher than current
            else
            {
                if (current.Right == null)
                {
                    current.Right = new Node(value);
                    this.Size += 1;
                    return;
                }
                else {
                    current = current.Right;
                }
            }
        }
    }

    // or this version
    public void InsertRecursively(T value)
    {
        this.Root = InsertRecursivelyHelper(this.Root, value);
    }

    public Node? InsertRecursivelyHelper(Node? node, T value)
    {
        // base case
        if (node == null) {
            this.Size += 1;
            return new Node(value);
        }

        // recursive step
        if (value.CompareTo(node.value) < 0)
        {
            node.Left = InsertRecursivelyHelper(node.Left, value);
        }
        else
        {
            node.Right = InsertRecursivelyHelper(node.Right, value);
        }

        return node;
    }
}