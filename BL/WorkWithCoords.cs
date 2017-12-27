using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkWithCoords 
    {
        public Point[] Coords { get; set; }

        public static Point[] RandomGeneration (int amount)
        {
            Point[] coord = new Point[amount];
            Random rand = new Random();
            for (int i = 0; i < amount; i++)
            {
                coord[i] = new Point { X = rand.Next(-50, 50), Y = rand.Next(-50, 50) };
            }
            return coord;

        }

        public double FindDistTo00 (Point instance)
        {           
            double x = instance.X;
            double y = instance.Y;
            double input = Math.Sqrt(x * x + y * y);
            return input;

        }

        public Point FirstQminSto00 (Point[] Coords)
        {
            var pointdist = new List<double>();
            
            for (int i = 0; i < Coords.Length; i++)
            {
                double x = Coords[i].X;
                double y = Coords[i].Y;
                if (x > 0 && y > 0)
                {
                    pointdist.Add(FindDistTo00(Coords[i]));
                                      
                }
              
            }
            int index = pointdist.IndexOf(pointdist.Min());

            return Coords[index];
            
        }

        public Point SecQminSto00(Point[] Coords)
        {
            var pointdist = new List<double>();

            for (int i = 0; i < Coords.Length; i++)
            {
                double x = Coords[i].X;
                double y = Coords[i].Y;
                if (x < 0 && y > 0)
                {
                    pointdist.Add(FindDistTo00(Coords[i]));

                }

            }
            int index = pointdist.IndexOf(pointdist.Min());

            return Coords[index];
        }
        public Point ThirdQminto00 (Point[] Coords)
        {
            var pointdist = new List<double>();

            for (int i = 0; i < Coords.Length; i++)
            {
                double x = Coords[i].X;
                double y = Coords[i].Y;
                if (x < 0 && y < 0)
                {
                    pointdist.Add(FindDistTo00(Coords[i]));

                }

            }
            int index = pointdist.IndexOf(pointdist.Min());

            return Coords[index];
        }
        public Point FourthQminSto00(Point[] Coords)
        {
            var pointdist = new List<double>();

            for (int i = 0; i < Coords.Length; i++)
            {
                double x = Coords[i].X;
                double y = Coords[i].Y;
                if (x > 0 && y < 0)
                {
                    pointdist.Add(FindDistTo00(Coords[i]));

                }

            }
            int index = pointdist.IndexOf(pointdist.Min());

            return Coords[index];
        }
    


      


    }
}
