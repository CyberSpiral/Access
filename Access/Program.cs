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

            foreach (var Tile in Map.OfType() {
                Tile.Contained.GetLocal(Map);
            }

            Console.WriteLine(Map[0,0].Contained.Number + ", " + Map[1, 0].Contained.Number);
            Console.Read();
        }
    }

    class Tile {

        public int X;
        public int Y;
        public Variable Contained { get; set; }

        public bool Contains { get; set; }

        public Tile (int x, int y) {
            X = x;
            Y = y;
        }

        public void AddToContainer(Variable v) {
            Contained = v;
            Contained.X = X;
            Contained.Y = Y;
            Contains = true;
        }

    }
        

    class Variable {
        public int Number { get; set; }
        public int X;
        public int Y;
        public Variable (int number) {
            this.Number = number;
        }
        public void GetLocal(Tile[,] T) {
            if (T[X + 1, Y].Contains) {
                T[X+1, Y].Contained.Number++;
            }
        }
    }
}
