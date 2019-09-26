using System;
using System.Collections;
using System.Collections.Generic;

namespace FAQ {

    public class Node<T> {
        public T Data;
        public ArrayList AdjListArray;
    }

    public class GraphAdjList<T> {
        int Count;

        Node<T>[] nodes;

        // constructor  
        public GraphAdjList (int verticesCount) {
            this.Count = verticesCount;
            nodes = new Node<T>[verticesCount];

            for (int i = 0; i < this.Count; i++) {
                Node<T> node = new Node<T> () { Data = (T) (object) i, AdjListArray = new ArrayList () };
                nodes[i] = node;
            }
        }

        public void addEdge (GraphAdjList<T> graph, int src, int dest) {

            nodes[src].AdjListArray.Add (dest);
            // Since graph is undirected, add an edge from dest to src also 
            nodes[dest].AdjListArray.Add (src);
        }

        public void printGraph (GraphAdjList<T> graph) {
            for (int v = 0; v < graph.nodes.Length; v++) {
                Console.WriteLine ("Adjacency list of vertex " + graph.nodes[v].Data);
                Console.WriteLine ("head");
                for (int i = 0; i < graph.nodes[v].AdjListArray.Count; i++) {
                    Console.Write (" -> " + graph.nodes[v].AdjListArray[i]);
                }
                Console.WriteLine ("\n");
            }
        }
    }
}