using System;
using System.Collections.Generic;
namespace FAQ {
    public class BasicGraph_AdjList_Test {
        public static void Test () {
            // create the graph given in above figure 
            int V = 5;
            GraphAdjList<int> graph = new GraphAdjList<int>(V);
            graph.addEdge (graph, 0, 1);
            graph.addEdge (graph, 0, 4);
            graph.addEdge (graph, 1, 2);
            graph.addEdge (graph, 1, 3);
            graph.addEdge (graph, 1, 4);
            graph.addEdge (graph, 2, 3);
            graph.addEdge (graph, 3, 4);

            // print the adjacency list representation of  
            // the above graph 
            graph.printGraph (graph);
        }
    }
}