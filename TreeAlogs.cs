
public class TreeAlgos<U> where U : IComparable<U>
{
    public static void PrintPreOrderRecursive(BinarySearchTree<U>.Node? node)
    {
        if (node != null)
        {
            // visit
            PrintValue(node);
            // left
            PrintPreOrderRecursive(node.Left);
            // right
            PrintPreOrderRecursive(node.Right);
        }
    }

    public static void PrintInOrderRecursive(BinarySearchTree<U>.Node? node)
    {
        if (node != null)
        {
            // left
            PrintInOrderRecursive(node.Left);
            // visit
            PrintValue(node);
            // right
            PrintInOrderRecursive(node.Right);
        }
    }

    public static void PrintPostOrderRecursive(BinarySearchTree<U>.Node? node)
    {
        if (node != null)
        {
            // left
            PrintPostOrderRecursive(node.Left);
            // right
            PrintPostOrderRecursive(node.Right);
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
            if (current.Right != null)
            {
                stack.Push(current.Right);
            }

            // add left to the stack (first out)
            if (current.Left != null)
            {
                stack.Push(current.Left);
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
                current = current.Left;
            }

            current = stack.Pop()!;

            // visit
            PrintValue(current);

            // go right
            current = current.Right;
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

            if (current.Left != null)
            {
                stack1.Push(current.Left);
            }
            if (current.Right != null)
            {
                stack1.Push(current.Right);
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