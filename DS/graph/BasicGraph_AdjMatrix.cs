using System;
using System.Collections;
using System.Collections.Generic;

namespace FAQ {
    public class GraphAdjMatrix {
        int no_of_vertex;
        int[, ] matrix;
        public GraphAdjMatrix (int vertex) {
            this.no_of_vertex = vertex;
            this.matrix = new int[vertex, vertex];
        }
        public void addEdge (int src, int dest) {
            this.matrix[src, dest] = 1;
            // for undireted
            this.matrix[dest, src] = 1;
        }
        public void printGraph () {
            Console.WriteLine ("Graph: (Adjacency Matrix)");
            for (int i = 0; i < no_of_vertex; i++) {
                for (int j = 0; j < no_of_vertex; j++) {
                    Console.Write (matrix[i, j] + " ");
                }
                Console.WriteLine ();
            }
            for (int i = 0; i < no_of_vertex; i++) {
                Console.Write ("Vertex " + i + " is connected to:");
                for (int j = 0; j < no_of_vertex; j++) {
                    if (matrix[i, j] == 1) {
                        Console.Write (j + " ");
                    }
                }
                Console.WriteLine ();
            }
        }
    }

}