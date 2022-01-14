namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Field field = new Field(20);
            Ship ship = new Ship(10, 5);
            Ship ship2 = new Ship(5, 6);
            Ship ship3 = new Ship(12, 8);
            Ship ship4 = new Ship(15, 2);
            field.AddShip(10, 15, 1, ship, 'U');
            field.AddShip(12, 13, 2, ship2, 'U');
            field.AddShip(2, 5, 3, ship3, 'R');
            field.AddShip(8, 6, 4, ship4, 'U');
            Console.Write(field.ToString());
            

        }
    }
}