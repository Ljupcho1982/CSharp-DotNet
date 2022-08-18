using System.Collections.Generic;
///Depth First Traversal-Tree
///


 void DephtFirstSearchTraversalOnTree(Node root)
{
    Stack<Node> nodes = new Stack<Node>();

    nodes.Push(root);
    while (nodes.Count > 0)
    {

        Node node = nodes.Pop();
        if(node.right != null)
        {
        nodes.Push(node.right);  

        }
        if (node.left != null)
        {

            nodes.Push(node.left);
        }
        Console.WriteLine(""+node.data);
    }


}


HashSet<int>DepthFirstSearchTraversalOnGraph(Node root)
{

    HashSet<int> visited=new HashSet<int>();
    if (!graph.AdjancencyList.ContainsKey(root))
    {

        return visited;

    }

    Stack<int> stack=new Stack<int>();
    stack.Push(root.data);
    while (stack.Count > 0)
    {

        int vertex = stack.Pop();

        if (visited.Contains(vertex))
        {

            continue;
        }

        visited.Add(vertex);
        foreach (var neighbor in graph.AdjancencyList[vertex])
        {
            if (!visited.Contains(neighbor))
            {

                stack.Push(neighbor);
            }
        }

        return visited; 
    }
}
class Node
{
    public Node left;
    public Node right;
    public Node data;

}