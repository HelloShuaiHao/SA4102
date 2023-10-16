using Algo;

int[] keys = new int[] { 27, 14, 35, 10, 19, 31, 42 };

BST bst = new BST();

// build BST
for (int i = 0; i < keys.Length; i++) {
    bst.Insert(new Node(keys[i]));
}

// depth-first traversal
Console.Write("Depth-First (Prefix): ");
bst.DepthFirst(BST.PREFIX);

Console.Write("Depth-First (Infix): ");
bst.DepthFirst(BST.INFIX);

Console.Write("Depth-First (Postfix): ");
bst.DepthFirst(BST.POSTFIX);

// breadth-first traversal
Console.Write("Breath-First: ");
bst.BreadthFirst();


// recursively find number
Console.Write("Recursive find(19): ");
if(bst.RecursiveFind(19) != null) Console.Write(bst.RecursiveFind(19).key);


Console.WriteLine();

Console.Write("Iterative find(19): ");
if(bst.IterativeFind(30) != null ) Console.Write(bst.IterativeFind(30).key);



Console.ReadKey();

