namespace ConsoleApp1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        Quadrant q;
        public bool IsAvailabel { get; set; } = true;
        public Ship ship;
        public double DistFromCenter { get { return (Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2))); } }



        public Point(int x, int y, int q)
        {
            X = x; Y = y; this.q = (Quadrant)q;
        }

        public override string ToString()
        {
            return ($"Coordinates of the point are ({X}; {Y} {q};)");
        }

    }

    public enum Quadrant
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        First_Second = 5,
        Second_Third = 6,
        Third_Fourth = 7,
        Fourth_First = 8,
        Center = 9
    };
}
