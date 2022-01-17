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
                int index = Convert.ToInt32(str);
                PointsOfField.Add(index, value);
            }
            get
            {
                string str = ($"{X}{Y}{Q}");
                int index = Convert.ToInt32(str);
                return PointsOfField[index];
            }
        }


        public void MoveShip(int X, int Y, int Q, char direct)
        {
            Ship ship = PointsOfShip[this[X, Y, Q]];
            Point point = PointsOfShip.Where(x => x.Value == ship).FirstOrDefault().Key;
            int x = point.X;
            int y = point.Y;
            int q = Convert.ToInt32(point.quadrant);

            switch (direct)
            {
                case 'U' or 'D':

                    for (int i = 0; i < ship.Speed; i++)
                    {

                        // delete ship info from old point
                        this[x, y, q].ship = null;
                        this[x, y, q].IsAvailabel = true;
                        PointsOfShip.Remove(this[x, y, q]);

                        int newY = y + ship.Length;

                        //add new point
                        AddNewPointToShip(x, newY, q, ship);

                        y++;
                    }
                    SelectTheMinDist(ship);
                    break;
                


                case 'R' or 'L':

                    for (int i = 0; i < ship.Speed; i++)
                    {

                        // delete ship info from old point
                        this[x, y, q].ship = null;
                        this[x, y, q].IsAvailabel = true;
                        PointsOfShip.Remove(this[x, y, q]);

                        int newX = x + ship.Length;

                        //add new point

                        AddNewPointToShip(newX, y, q, ship);
                        
                        x++;
                    }
                    SelectTheMinDist(ship);

                    break;
               
            }
        }

        public void AddShip(int X, int Y, int Q, Ship ship, char direct)
        {
            

            if (listOfShips.Contains(ship))
            {
                throw new Exception("The ship is already on the field");
            }




            switch (direct)
            {
                case 'U':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        AddNewPointToShip(X, Y, Q, ship);
                        
                        Y++;
                    }
                    break;

                case 'R':
                    for (int i = 0; i < ship.Length; i++)
                    {
                        AddNewPointToShip(X, Y, Q, ship);

                        X++;
                    }
                    break;
            }

            SelectTheMinDist(ship);
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
                str += ("\n" + ship.ToString() + "\n" + "Points of the ship:\n");
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

        public void SelectTheMinDist(Ship ship)
        {
            ship.MinDist = Size;
            foreach (var ps in PointsOfShip)
            {
                if (ps.Value == ship)
                {
                    if (ps.Key.DistFromCenter < ship.MinDist)
                    {

                        ship.MinDist = ps.Key.DistFromCenter;
                    }
                }
            }
        }

        public void AddNewPointToShip(int X, int Y, int Q, Ship ship)
        {
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

            PointsOfShip.Add(this[X, Y, Q], ship);
        }
    }
}
