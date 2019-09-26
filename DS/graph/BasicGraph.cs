using System;
using System.Collections.Generic;
namespace FAQ {
    public class BasicGraph {
        private List<int>[] childNodes;
        public BasicGraph (int size) {
            this.childNodes = new List<int>[size];
            for (int i = 0; i < size; i++) {
                this.childNodes[i] = new List<int> ();
            }
        }
        public BasicGraph (List<int>[] childNodes) {
            this.childNodes = childNodes;
        }

        public int Size {
            get { return this.childNodes.Length; }
        }
        public void AddEdge (int u, int v) {
            childNodes[u].Add (v);
        }
        public void RemoveEdge (int u, int v) {
            childNodes[u].Remove (v);
        }
        public bool HasEdge (int u, int v) {
            bool hasEdge = childNodes[u].Contains (v);
            return hasEdge;
        }
        public IList<int> GetSuccessors (int v) {
            return childNodes[v];
        }
    }
}