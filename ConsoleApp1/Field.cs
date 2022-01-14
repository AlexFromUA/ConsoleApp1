namespace ConsoleApp1
{
    public class Field
    {
        int Size { get; set; }
        public Dictionary<int, Point> PointsOfField = new Dictionary<int, Point>();

        public Dictionary<Point, Ship> PointsOfShip = new Dictionary<Point, Ship>();

        List<Ship> listOfShips = new List<Ship>();

        
        public Field(int s)
        {
            Size = s;
        }
        public Point this[int X, int Y, int Q]
        {
            set
            {
                string str = ($"{X}{Y}{Q}");
                int index = Convert.ToInt32(str) ;
                PointsOfField.Add(index, value);
            }
            get
            {
                string str = ($"{X}{Y}{Q}");
                int index = Convert.ToInt32(str);
                return PointsOfField[index];
            }
        }
        



        public void AddShip(int X, int Y, int Q, Ship ship, char direct)
        {
            ship.MinDist = Size;
            
            if (listOfShips.Contains(ship))
            {
                throw new Exception("The ship is already on the field");
            }
            



            switch (direct)
            {
                case 'U':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        // It is possible that one of the points will be not available 
                        // So the actual length will not be equal to length in ship.length 
                        Y += i;
                        string str = ($"{X}{Y}{Q}");
                        int index = Convert.ToInt32(str);
                        
                        // Check the existing of the Point
                        if (!PointsOfField.ContainsKey(index))
                        {
                            this[X, Y, Q] = new Point(X, Y, Q);
                        }

                        // Check the availbility of the Point
                        if (!this[X, Y, Q].IsAvailabel) { throw new Exception("The point isn't available"); }  
                        
                        this[X, Y, Q].ship = ship;
                        this[X, Y, Q].IsAvailabel = false;

                        // Set the the minimum distance from ship to the center
                        if (this[X, Y, Q].DistFromCenter < ship.MinDist)
                        {

                            ship.MinDist = this[X, Y, Q].DistFromCenter;
                        }

                        PointsOfShip.Add(this[X, Y, Q], ship);
                    }
                    break;

                case 'R':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        X += i;
                        string str = ($"{X}{Y}{Q}");
                        int index = Convert.ToInt32(str);
                        if (!PointsOfField.ContainsKey(index))
                        {
                            this[X, Y, Q] = new Point(X, Y, Q);
                        }
                        if (this[X, Y, Q].IsAvailabel != true) { throw new Exception("The point isn't available"); }                        
                        this[X, Y, Q].ship = ship;
                        this[X, Y, Q].IsAvailabel = false;
                        if (this[X, Y, Q].DistFromCenter < ship.MinDist)
                        {

                            ship.MinDist = this[X, Y, Q].DistFromCenter;
                        }

                        PointsOfShip.Add(this[X, Y, Q], ship);
                    }
                    break;
            }
            listOfShips.Add(ship);
        }
        public override string ToString()
        {

            for (int i = 0; i < listOfShips.Count(); i++)
            {
                for (int j = i + 1; j < listOfShips.Count(); j++)
                {
                    if (listOfShips[i].MinDist > listOfShips[j].MinDist)
                    {
                        Ship temp = listOfShips[i];
                        listOfShips[i] = listOfShips[j];
                        listOfShips[j] = temp;
                    }
                }
            }

            string str = "";
            foreach (var ship in listOfShips)
            {
                str += ("\n" + ship.ToString() + "\n" + "Points of the ship:\n" );
                foreach (var p in PointsOfShip)
                {
                    if (p.Value == ship) 
                    {
                        str += (p.Key.ToString() + "\n");
                    }
                }
            }
            return str;
        }
    }
}
