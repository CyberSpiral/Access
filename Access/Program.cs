using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access {
    class Program {
        static void Main(string[] args) {
            Variable c, t;
            c = new Variable(3);
            t = new Variable(10);
            Tile[,] Map = new Tile[5, 5];

            for (int x = 0; x < 5; x++) {
                for (int y = 0; y < 5; y++) {
                    Map[x, y] = new Tile(x,y);
                }
            }

            Map[0, 0].AddToContainer(c);
            Map[1, 0].AddToContainer(t);


            Console.WriteLine(Map[0,0].Contained.Number + ", " + Map[1, 0].Contained.Number);
            Console.Read();
        }
    }

    
}
