using System;
using System.Collections.Generic;

public class GraphChallenge
{
    public static string GraphChallengeMethod(string[] strArr)
    {
        int n = int.Parse(strArr[0]);
        string startNode = strArr[1];
        string endNode = strArr[n];

        Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();

        // Initialize graph nodes
        for (int i = 1; i <= n; i++)
        {
            graph[strArr[i]] = new List<string>();
        }

        // Add edges to the graph
        for (int i = n + 1; i < strArr.Length; i++)
        {
            string[] nodes = strArr[i].Split('-');
            string node1 = nodes[0];
            string node2 = nodes[1];

            graph[node1].Add(node2);
            graph[node2].Add(node1);
        }

        // Perform BFS to find the shortest path
        Queue<string> queue = new Queue<string>();
        Dictionary<string, string> previousNode = new Dictionary<string, string>();
        HashSet<string> visited = new HashSet<string>();

        queue.Enqueue(startNode);
        visited.Add(startNode);

        while (queue.Count > 0)
        {
            string currentNode = queue.Dequeue();

            if (currentNode == endNode)
            {
                break;
            }

            foreach (var neighbor in graph[currentNode])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    previousNode[neighbor] = currentNode;
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Reconstruct the path from endNode to startNode
        if (!visited.Contains(endNode))
        {
            return "-1";
        }

        List<string> path = new List<string>();
        for (string at = endNode; at != null; at = previousNode.ContainsKey(at) ? previousNode[at] : null)
        {
            path.Add(at);
        }
        path.Reverse();

        return string.Join("-", path);
    }

    public static void Main()
    {
        string[] input1 = { "5", "A", "B", "C", "D", "F", "A-B", "A-C", "B-C", "C-D", "D-F" };
        string[] input2 = { "4", "X", "Y", "Z", "W", "X-Y", "Y-Z", "X-W" };

        Console.WriteLine(GraphChallengeMethod(input1)); // Output: A-C-D-F
        Console.WriteLine(GraphChallengeMethod(input2)); // Output: X-W
    }
}
