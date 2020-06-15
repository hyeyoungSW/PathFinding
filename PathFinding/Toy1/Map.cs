using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinding
{
    class Map
    {
        public int min_idx = 10;
        public static int map_size = 400;
        public int[,] costmap = new int[map_size, map_size];
        public int[,] heuristicmap = new int[map_size,map_size];
        public bool[,] visitedmap = new bool[map_size, map_size];
        public List<Wall> walllist = new List<Wall>();

        public Map(Tuple <int,int> endpoint)
        {
            //init_costmap();
            init_heuristicmap(endpoint.Item1, endpoint.Item2);
            init_visitedmap();
        }
        public Map(Tuple <int, int> endpoint, List <Wall> walllist)
        {
            foreach(Wall wall in walllist)
            {
                this.walllist.Add(wall);
            }
            init_costmap();
            init_heuristicmap(endpoint.Item1, endpoint.Item2);
            init_visitedmap();
        }

        public int get_size()
        {
            return map_size;
        }

        public int get_heuristic(int x, int y)
        {
            return heuristicmap[x, y];    
        }

        public void set_cost(Tuple<int, int> start, Tuple<int, int> dest)
        {
            if(costmap[dest.Item1, dest.Item2] == 1000)
            {
                return;
            }
            int dist =  (int)(Math.Sqrt(Math.Pow(dest.Item1 - start.Item1, 2) + Math.Pow(dest.Item2 - start.Item2, 2)) *100);
            costmap[dest.Item1, dest.Item2] = dist;            
        }

        public int get_cost(Tuple <int, int> node)
        {
            return costmap[node.Item1, node.Item2];
        }

        public int get_cost(int x, int y)
        {
            return costmap[x, y];
        }

        private void init_heuristicmap(int x, int y)    //heuristic using mahattan distance
        {
            for (int i = 0; i < map_size; i++)
            {
                for (int j = 0; j < map_size; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(x - (i + min_idx), 2) + Math.Pow(y - (j + min_idx), 2));
                    heuristicmap[i,j] = (int)(dist*10);
                }
            }
        }

        public void init_visitedmap()
        {
            for(int i=0; i<map_size; i++)
            {
                for(int j=0; j<map_size; j++)
                {
                    visitedmap[i, j] = false;
                }
            }
            
            foreach (Wall wall in walllist)
            {
                for (int i = wall.x; i < wall.x + wall.width; i++)
                {
                    for (int j = wall.y; j < wall.y + wall.height; j++)
                    {
                        visitedmap[i, j] = true;
                    }
                }
            }
        }

        private void init_costmap()
        {
            foreach (Wall wall in walllist)
            {
                for(int i=wall.x; i<=wall.width + wall.x; i++)
                {
                    for(int j=wall.y; j<=wall.height + wall.y; j++)
                    {
                        costmap[i, j] = 1000;                        
                    }
                }
            }
        }

        public bool canExtend(int x, int y)
        {
            if (x > 0 && x < map_size && y > 0 && y < map_size)
            {
                if (visitedmap[x, y] == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void visit(int x, int y)
        {
            if (x < map_size && x > 0 && y < map_size && y > 0)
            {
                visitedmap[x, y] = true;
            }
        }
    }
}
