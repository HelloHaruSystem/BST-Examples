Console.Clear();
Console.WriteLine("Hello, World!");
BinarySearchTree<int> bst = new BinarySearchTree<int>();

/* Pre-order
bst.InsertIterative(64);
bst.InsertIterative(32);
bst.InsertIterative(256);
bst.InsertIterative(16);
bst.InsertIterative(2048);
bst.InsertIterative(8);
bst.InsertIterative(128);
bst.InsertIterative(1024);
bst.InsertIterative(2);
bst.InsertIterative(4096);
bst.InsertIterative(4);
bst.InsertIterative(512);
bst.InsertIterative(1);

TreeAlgos<int>.PrintPreOrderIterative(bst.Root);
Console.WriteLine();
TreeAlgos<int>.PrintPreOrderRecursive(bst.Root);
*/

/* In-order
bst.InsertIterative(27);
bst.InsertRecursively(15);
bst.InsertRecursively(20);
bst.InsertRecursively(25);
bst.InsertRecursively(9);
bst.InsertRecursively(7);
bst.InsertRecursively(14);
bst.InsertRecursively(12);
bst.InsertRecursively(28);
bst.InsertRecursively(30);
bst.InsertRecursively(29);
bst.InsertRecursively(36);

TreeAlgos<int>.PrintInOrderIterative(bst.root);
Console.WriteLine();
TreeAlgos<int>.PrintInOrderRecursive(bst.Root);
*/

// Post-order
bst.InsertRecursively(8);
bst.InsertIterative(4);
bst.InsertRecursively(16);
bst.InsertIterative(7);
bst.InsertRecursively(10);
bst.InsertIterative(2);
bst.InsertRecursively(11);
bst.InsertIterative(3);
bst.InsertRecursively(32);
bst.InsertIterative(9);

TreeAlgos<int>.PrintPostOrderIterative(bst.Root);
Console.WriteLine();
TreeAlgos<int>.PrintPostOrderRecursive(bst.Root);