using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PathFinding
{
    public partial class Form1 : Form
    {
        #region variables
        Timer timer = new Timer();
        private int[] dx = { 10, 10, 10, 0, -10, -10, -10, 0 };
        private int[] dy = { -10, 0, 10, 10, 10, 0, -10, -10 };       
        private int howmuchthinking = 0;
        private int iterative;
        private Map map;
        private static Tuple<int, int> startpoint = new Tuple<int, int>(10, 200);
        private static Tuple<int, int> endpoint = new Tuple<int, int>(390, 200);
        private static List<Wall> walllist;
        private Rectangle[] rectanglelist;
        private List<Tuple<int, int>> visitedmap;
        private static Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        private static SortedSet<Tuple<int, Tuple<int, int>>> queuelist = new SortedSet<Tuple<int, Tuple<int, int>>>();

        private bool isfound = false;        
        #endregion

        public Form1()
        {
            InitializeComponent();
            walllist = new List<Wall>();
            rectanglelist = new Rectangle[3];
            Wall wall1 = new Wall(100, 0, 50, 300);
            Rectangle r1 = new Rectangle(110, 10, 50, 300);
            Wall wall2 = new Wall(300, 95, 50, 300);
            Rectangle r2 = new Rectangle(310, 110, 50, 300);
            rectanglelist[0] = r1;
            walllist.Add(wall1);
            rectanglelist[1] = r2;
            walllist.Add(wall2);
            map = new Map(endpoint, walllist);
            visitedmap = new List<Tuple<int, int>>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = (100);
            timer.Tick += new EventHandler(timer_Tick);
            //timer.Start(); 
        }

        private void init_value()
        {
            queue.Clear();
            queue.Enqueue(startpoint);
            queuelist.Clear();
            queuelist.Add(new Tuple<int, Tuple<int, int>>(0, (startpoint)));
            isfound = false;
            visitedmap.Clear();
            map.init_visitedmap();
            timer.Start();
            howmuchthinking = 0;
        }

        private void makingEnvironment(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen_line = new Pen(Color.Blue, 4);
            Pen pen_point = new Pen(Color.Red, 4);
            Pen pen_path = new Pen(Color.Yellow, 4);
            Pen pen_wall = new Pen(Color.Blue, 4);

            g.DrawRectangles(pen_wall, rectanglelist);
            g.DrawRectangle(pen_line, map.min_idx - 2, map.min_idx - 2, map.get_size(), map.get_size()); // 10, 10 -> 410, 410
            foreach (Tuple<int, int> point in visitedmap)
            {
                g.DrawEllipse(pen_path, point.Item1 + map.min_idx, point.Item2 + map.min_idx, 4, 4);
            }
            g.DrawEllipse(pen_point, map.min_idx + startpoint.Item1, map.min_idx + startpoint.Item2, 4, 4);//start point
            g.DrawEllipse(pen_point, map.min_idx + endpoint.Item1, map.min_idx + endpoint.Item2, 4, 4);//goal point
            if (isfound == false)
            {
                textbox_thinktime.Text = "I can't find the path";
            }
            else
            {
                textbox_thinktime.Text = howmuchthinking.ToString();
            }
            
            Font f = new Font("Arial", 8);
            SolidBrush b = new SolidBrush(Color.Red);
            /*
            for (int i=20; i<400; i= i + 30)
            {
                for(int j=20; j<400; j= j + 30)
                {
                    g.DrawString((map.get_heuristic(i, j)).ToString(), f, b, i, j);
                }
            }*/
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panel_monitor.Refresh();
        }

        #region algorithm

        public void algorithm_DFS(int x, int y, int count)
        {
            visitedmap.Add(new Tuple<int, int>(x, y));
            if (count > iterative)
            {
                return;
            }
            howmuchthinking++;
            if (isfound == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    int posX = x + dx[i];
                    int posY = y + dy[i];
                    if (posX == endpoint.Item1 && posY == endpoint.Item2)
                    {
                        isfound = true;
                    }
                    else
                    {
                        if (map.canExtend(posX, posY) == true)
                        {
                            map.visit(posX, posY);
                            algorithm_DFS(posX, posY, count + 1);
                        }
                    }
                }
            }
        }   //DFS using recursion

        public void algorithm_BFS()
        {
            while (queue.Count != 0 && isfound == false)
            {
                int qsize = queue.Count;
                while (qsize != 0)
                {
                    qsize--;
                    Tuple<int, int> node = queue.Dequeue();
                    visitedmap.Add(new Tuple<int, int>(node.Item1, node.Item2));
                    if (node.Item1 == endpoint.Item1 && node.Item2 == endpoint.Item2)
                    {
                        isfound = true;
                        break;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        howmuchthinking++;
                        int xpos = node.Item1 + dx[i];
                        int ypos = node.Item2 + dy[i];
                        if (map.canExtend(xpos, ypos) == true)
                        {
                            queue.Enqueue(new Tuple<int, int>(xpos, ypos));
                            map.visit(xpos, ypos);
                        }

                    }
                }
            }
        }   //BFS using queue

        public void algorithm_UCS()
        {
            while (queuelist.Count != 0 && isfound == false)
            {
                int qsize = queuelist.Count();
                while (qsize != 0)
                {
                    qsize--;
                    Tuple<int, Tuple<int, int>> node = queuelist.First();
                    queuelist.Remove(node);

                    visitedmap.Add(node.Item2);
                    if (node.Item2.Item1 == endpoint.Item1 && node.Item2.Item2 == endpoint.Item2)
                    {
                        isfound = true;
                        break;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        howmuchthinking++;
                        int xpos = node.Item2.Item1 + dx[i];
                        int ypos = node.Item2.Item2 + dy[i];
                        if (map.canExtend(xpos, ypos) == true)
                        {
                            Tuple<int, int> extendnode = new Tuple<int, int>(xpos, ypos);
                            map.set_cost(node.Item2, extendnode);
                            map.visit(xpos, ypos);
                            queuelist.Add(new Tuple<int, Tuple<int, int>>(map.get_cost(extendnode), extendnode));
                        }
                    }
                }
            }
        }

        public void algorithm_Greedy(int x, int y)
        {
            howmuchthinking++;

            if (isfound == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    int posX = x + dx[i];
                    int posY = y + dy[i];
                    if (posX == endpoint.Item1 && posY == endpoint.Item2)
                    {
                        isfound = true;
                    }
                    else
                    {
                        if (map.canExtend(posX, posY) == true)
                        {
                            queuelist.Add(new Tuple<int, Tuple<int, int>>(map.get_heuristic(posX, posY), new Tuple<int, int>(posX, posY)));
                            visitedmap.Add(new Tuple<int, int>(x, y));
                        }
                    }
                }

                Tuple<int, Tuple <int, int>> expandnode = queuelist.First();
                queuelist.Remove(expandnode);
                map.visit(expandnode.Item2.Item1, expandnode.Item2.Item2);
                algorithm_Greedy(expandnode.Item2.Item1, expandnode.Item2.Item2);
            }
        }  

        public void algorithm_Astar(int x, int y)
        {
            howmuchthinking++;
            textbox_thinktime.Text = howmuchthinking.ToString();
            visitedmap.Add(new Tuple<int, int>(x, y));
            if (isfound == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    int posX = x + dx[i];
                    int posY = y + dy[i];
                    if (posX == endpoint.Item1 && posY == endpoint.Item2)
                    {
                        isfound = true;
                    }
                    else
                    { 
                        if (map.canExtend(posX, posY) == true)
                        {
                            int totalcost = map.get_heuristic(posX, posY) + map.get_cost(posX, posY);
                            queuelist.Add(new Tuple<int, Tuple<int, int>>(totalcost, new Tuple<int, int>(posX, posY)));                           
                        }
                    }
                }
                Tuple <int, Tuple<int, int>> expandnode = queuelist.First();
                map.visit(expandnode.Item2.Item1, expandnode.Item2.Item2);
                queuelist.Remove(expandnode);
                algorithm_Astar(expandnode.Item2.Item1, expandnode.Item2.Item2);
            }
        }
        #endregion

        #region button control
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_algo_Click(object sender, EventArgs e)
        {            
            Button algorithm = (Button)sender;
            init_value();
            textbox_thinktime.Enabled = true;

            if (algorithm.Text.CompareTo("BFS") == 0)
            {
                algorithm_BFS();
            }
            else if (algorithm.Text.CompareTo("DFS") == 0)
            {                
                iterative = (int)updown_iterative.Value;
                algorithm_DFS(startpoint.Item1, startpoint.Item2, 1);
            }
            else if (algorithm.Text.CompareTo("UCS") == 0)
            {
                algorithm_UCS();
            }
            else if (algorithm.Text.CompareTo("Greedy") == 0)
            {
                algorithm_Greedy(startpoint.Item1, startpoint.Item2);

            }
            else if (algorithm.Text.CompareTo("A*") == 0)
            {
                algorithm_Astar(startpoint.Item1, startpoint.Item2);
            }
        }
        #endregion
    }
}
