using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    public class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];
            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var col = edge.To.Number - 1;
                matrix[row, col] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertexLists(Vertex vertex)
        {
            var result = new List<Vertex>();
            foreach (var edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }

        public List<Vertex> Wave(Vertex start, Vertex finish)
        {
            var result = new List<Vertex>();
            var list = new List<Vertex>();
            list.Add(start);
            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var v in GetVertexLists(vertex))
                {
                    if (!list.Contains(v))
                    {
                        list.Add(v);
                    }
                }
            }
            return list;
        }

        public LinkedList<Vertex> DFS(Vertex start, Vertex goal)
        {
            visited = new HashSet<Vertex>();
            path = new LinkedList<Vertex>();
            DFS(start);
            if (path.Count > 0)
            {
                path.AddFirst(start);
            }
            return path;
        }
        private bool DFS(Vertex vert)
        {
            
            if (vert == goal)
            {
                return true;
            }
            visited.Add(vert);
            foreach (var child in vert.children.Where(x => !visited.Contains(x)))
            {
                if (DFS(child))
                {
                    path.AddFirst(child);
                    return true;
                }
            }
            return false;
        }
        public List<Vertex> children = new List<Vertex>();
        // Список посещенных вершин
        private HashSet<Vertex> visited;
        // Путь из начальной вершины в целевую.
        private LinkedList<Vertex> path;
        private Vertex goal;

  
    }
}
