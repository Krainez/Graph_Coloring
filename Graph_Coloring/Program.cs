using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of vertices");
            int n = int.Parse(Console.ReadLine());
            Graph g = new Graph(n);
            Console.WriteLine("Enter the number of edges");
            int n_edges = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_edges; i++)
            {
                string[] s = Console.ReadLine().Split('-');
                g.addEdge(Convert.ToInt16(s[0]), Convert.ToInt16(s[1]));
            }
            Console.WriteLine("Coloring of graph");
            g.greedyColoring();

            Console.ReadKey();
        }
    }
}
