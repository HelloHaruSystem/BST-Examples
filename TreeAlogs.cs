
public class TreeAlgos<U> where U : IComparable<U>
{
    public static void PrintPreOrderRecursive(BinarySearchTree<U>.Node? node)
    {
        if (node != null)
        {
            // visit
            PrintValue(node);
            // left
            PrintPreOrderRecursive(node.left);
            // right
            PrintPreOrderRecursive(node.right);
        }
    }

    public static void PrintInOrderRecursive(BinarySearchTree<U>.Node? node)
    {
        if (node != null)
        {
            // left
            PrintInOrderRecursive(node.left);
            // visit
            PrintValue(node);
            // right
            PrintInOrderRecursive(node.right);
        }
    }

    public static void PrintPostOrderRecursive(BinarySearchTree<U>.Node? node)
    {
        if (node != null)
        {
            // left
            PrintPostOrderRecursive(node.left);
            // right
            PrintPostOrderRecursive(node.right);
            // visit
            PrintValue(node);
        }
    }

    public static void PrintPreOrderIterative(BinarySearchTree<U>.Node? node)
    {
        if (node == null)
        {
            return;
        }

        Stack<BinarySearchTree<U>.Node?> stack = new();

        stack.Push(node);

        while (stack.Count > 0)
        {
            var current = stack.Pop()!;
            PrintValue(current);

            // add right to the stack (last out)
            if (current.right != null)
            {
                stack.Push(current.right);
            }

            // add left to the stack (first out)
            if (current.left != null)
            {
                stack.Push(current.left);
            }
        }
    }

    public static void PrintInOrderIterative(BinarySearchTree<U>.Node? node)
    {
        if (node == null)
        {
            return;
        }

        // single stack for In-order
        Stack<BinarySearchTree<U>.Node?> stack = new();

        // start current at the root
        BinarySearchTree<U>.Node? current = node;
        
        // while there are nodes to process
        while (current != null || stack.Count > 0)
        {
            // go left
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop()!;

            // visit
            PrintValue(current);

            // go right
            current = current.right;
        }
    }

    public static void PrintPostOrderIterative(BinarySearchTree<U>.Node? node)
    {
        if (node == null)
        {
            return;
        }

        Stack<BinarySearchTree<U>.Node?> stack1 = new();
        Stack<BinarySearchTree<U>.Node?> stack2 = new();

        stack1.Push(node);

        while (stack1.Count > 0)
        {
            var current = stack1.Pop()!;
            stack2.Push(current);

            if (current.left != null)
            {
                stack1.Push(current.left);
            }
            if (current.right != null)
            {
                stack1.Push(current.right);
            }
        }

        // print the values
        while (stack2.Count > 0)
        {
            var current = stack2.Pop()!;
            PrintValue(current);
        }
    }

    private static void PrintValue(BinarySearchTree<U>.Node node)
    {
        Console.Write("{0}\n", node.value);
    }
}