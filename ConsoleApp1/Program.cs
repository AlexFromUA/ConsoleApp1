namespace ConsoleApp1
{
    class Points
    {
        public int X;
        public int Y;
        public int Quadrant;

        public Points (int x, int y, int q)
        {
            X = x; Y = y; Quadrant = q; 
        }

        public override string ToString()
        {
            return ($"Coordinates are ({X}; {Y}; {Quadrant})");
        }
    }

    class Ship
    {
        
        int MaxSpeed = 10;
        bool IsDead = false;
        List<Points> points = new List<Points>() { new Points(5, 2, 1), new Points(5, 3, 1) };
        int length = 2;

        public void Move(char Direction, int speed)
        {
            if (speed > MaxSpeed)
            {
                throw new Exception("Speed is bigger than max speed!");
            }
            switch (Direction)
            {
                case 'U': 
                    foreach (Points p in points)
                    {
                        p.Y += speed;
                    }
                    break;
                case 'D':
                    foreach (Points p in points)
                    {
                        p.Y -= speed;
                    }
                    break;

                case 'R':
                    foreach (Points p in points)
                    {
                        p.X += speed;
                    }
                    break;
                case 'L':
                    foreach (Points p in points)
                    {
                        p.X -= speed;
                    }
                    break;

            }
        }

        public override string ToString()
        {
            string str = "";
            int i = 1;
            foreach (Points p in points)
            {
                str += ($"{i} point: {p.ToString()}. ");
                i++;
            }
            string str2 = ($"Length is {length}. ");
            str2 += str;
            return (str2);
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Ship ship = new Ship(); 
            Console.WriteLine(ship.ToString());
            ship.Move('L');
            Console.WriteLine(ship.ToString());

        }
    }
}