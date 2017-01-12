using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShortestPath
{
    class Dijkstra
    {
        public const int V = 9;
        static void Main(string[] args)
        {
            int[,] graph =
                        { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                        { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                        { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                        { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                        { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                        { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                        { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                        { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                        { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
                        };

            CalculateShortestPath(graph, 0);

        }

        static void CalculateShortestPath(int[,] graph, int source)
        {
            //shortest distance b/w source and i th variable
            int[] dist = new int[V];

            bool[] isVisited = new bool[V];

            //initializing
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                isVisited[i] = false;
            }

            dist[source] = 0;

            for (int i = 0; i < V - 1; i++)
            {
                //Find the minimum cost to reach the vertix (u) using all possible known path
                //with i th jump 
                int u = MinDist(dist, isVisited);
                isVisited[u] = true;

                for (int j = 0; j < V; j++)
                {
                    if (!isVisited[j]
                        && graph[u, j] != 0 //must be an edge from uth vertex to j th vetex
                        && dist[u] != int.MaxValue  //path already found for u
                        && dist[u] + graph[u, j] < dist[j]) //eithe first time considering the vertex or new path cost is minimum

                        dist[j] = dist[u] + graph[u, j];
                }

            }
            printSolution(dist);
        }
        /// <summary>
        /// Minm cost unvisited vertex
        /// </summary>
        /// <param name="dist"></param>
        /// <param name="isVisited"></param>
        /// <returns></returns>
        static int MinDist(int[] dist, bool[] isVisited)
        {
            int min = int.MaxValue, min_Indx = 0;
            for (int i = 0; i < V; i++)
            {
                if (isVisited[i] == false && dist[i] <= min)
                {
                    min = dist[i];
                    min_Indx = i;
                    //break;
                }
            }
            return min_Indx;
        }

        static void printSolution(int[] dist)
        {
            Console.Write("Vertex   Distance from Source\n");
            for (int i = 0; i < V; i++)
                Console.Write(i.ToString() + "\t\t " + dist[i].ToString() + "\n");
        }
    }
}
