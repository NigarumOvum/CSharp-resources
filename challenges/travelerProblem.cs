using System;
using System.Collections.Generic;
using SYstem.Linq

nameSpace Traveler
{
    class Program{
        static void Main(string[] args)
        {
            Node NodeA = new Node() {City = "A";}
            Node NodeB = new Node() {City = "B";}
            Node NodeC = new Node() {City = "C";}
            Node NodeD = new Node() {City = "D";}
            
            NodeA.Ways.Add(new Way() {Node= NodeB, Distance = 5 });
            NodeA.Ways.Add(new Way() {Node= NodeC, Distance = 15 });
            NodeA.Ways.Add(new Way() {Node= NodeD, Distance = 7 });

            NodeB.Ways.Add(new Way() {Node= NodeA, Distance = 5 });
            NodeB.Ways.Add(new Way() {Node= NodeC, Distance = 10 });
            NodeB.Ways.Add(new Way() {Node= NodeD, Distance = 5 });

            NodeC.Ways.Add(new Way() {Node= NodeA, Distance = 15 });
            NodeC.Ways.Add(new Way() {Node= NodeB, Distance = 10 });
            NodeC.Ways.Add(new Way() {Node= NodeD, Distance = 3 });
            
            NodeD.Ways.Add(new Way() {Node= NodeA, Distance = 7 });
            NodeD.Ways.Add(new Way() {Node= NodeB, Distance = 5 });
            NodeD.Ways.Add(new Way() {Node= NodeC, Distance = 3 });

            List<Node> graph = new List<Node>() 
            {
            NodeA, NodeB, NodeC, NodeD
            };

            var algorithm = new Algorithm(graph, 3, NodeA);
            algorithm.Run();
            console.WriteLine(Algorithm.GetAllRoutes())''
        }
    }

    public class Algorithm 
    {
        private List<Node> _graph {get; set;};
        private int _n;
        private Node _origin {get; set;};
        private List<Route> _solutions {get; set;};

        public string GetAllRoutes
        {
            get {
                string result = "";

                foreach (var route in _solutions)
                {
                    foreach(var node in route.Nodes)
                    {
                        result += node.City + ",";
                    }
                    result += " " + route.TotalDistance + "\n";
                }
                return result
            }
        }

        public Algorithm(List<Node> graph, int n, node origin)
        {
            _graph = graph;
            _n = n;
            _origin = origin;
        }

        public void Run()
        {
            _solutions = new List<Route>();

            for (int i=0; i<_n; i++) 
            {
                _solutions.add(Generate());
            }
            _solutions = solutions.orderBy(d=> d.TotalDistance).toList();
        }

        private Route Generate()
        {
            var solution = new Route();

            solution.Nodes.Add(_origin);
            Node current = _origin;

            for (int i=0; i<_graph.Count -1; i++)
            {
                node next = null;
                do
                {
                    next = NextNode(current);
                } while (solution.Nodes.Contains(next));

                solution.Nodes.Add(next);
                solution.TotalDistance += current.Ways.Where(d=> d.Node.City == next.City).First().Distance();

                current = next;
            }

            solution.Nodes.Add(_origin);
            return solution;
        }

        private Node NextNode(Node current)
        {
            int nextNode = new Random().Next(0, _graph.Count -1);
            return current.Ways[nextNode].Node;
        }
    }

    public class Node
    {
        public string City {get; set;}
        public List<Way> Ways {get; set;}

        public Node(){
            Ways = new List<Way>();
        }
    }
    public struct class Way
    {
        public Node Node {get; set;}
        public int Distance {get; set;}
    }
    public Class Route
    {
        public List<Node> Nodes {get; set;}
        public int TotalDistance {get; set;}

        publi Route()
        {
            nodes = new List<Node>();
            TotalDistance = 0;
        }
    }
}
