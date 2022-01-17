namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Field field = new Field(20);
            Ship ship = new Battleship(2, 5);
            Ship ship2 = new Battleship(2, 5);
            Ship ship3 = new Battleship(12, 8);
            Ship ship4 = new Combinedship(15, 2);

            Console.WriteLine(ship == ship2);
            Console.WriteLine(ship != ship2);
            Console.WriteLine(ship == ship3);
            Console.WriteLine(ship == ship4);


            field.AddShip(10, 15, 1, ship, 'R');                       
            Console.Write(field.ToString());
            field.MoveShip(10, 15, 1, 'R');
            Console.Write(field.ToString());


        }
    }
}