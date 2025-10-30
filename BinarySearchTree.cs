public class BinarySearchTree<T> where T : IComparable<T>
{   
    // Internal class Node
    public class Node
    {
        public T value { get; set; }
        public Node? left;
        public Node? right;

        public Node(T value) 
        {
            this.value = value;
            this.left = null;
            this.right = null;
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
                if (current.left == null)
                {
                    current.left = new Node(value);
                    this.Size += 1;
                    return;
                } 
                else
                {
                    current = current.left;
                }
            }
            // higher than current
            else
            {
                if (current.right == null)
                {
                    current.right = new Node(value);
                    this.Size += 1;
                    return;
                }
                else {
                    current = current.right;
                }
            }
        }
    }

    // or this version
    public void InsertRecursively(T value)
    {
        this.Root = InsertRecursivelyHelper(this.Root, value);
        this.Size += 1;
    }

    public Node? InsertRecursivelyHelper(Node? node, T value)
    {
        // base case
        if (node == null) {
            return new Node(value);
        }

        // recursive step
        if (value.CompareTo(node.value) < 0)
        {
            node.left = InsertRecursivelyHelper(node.left, value);
        }
        else
        {
            node.right = InsertRecursivelyHelper(node.right, value);
        }

        return node;
    }
}