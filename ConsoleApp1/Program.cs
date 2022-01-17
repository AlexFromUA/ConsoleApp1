namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Field field = new Field(20);
            Ship ship = new Battleship(2, 5);
            Ship ship2 = new Battleship(3, 5);

           /* Ship ship3 = new Supportship(12, 8);
            Ship ship4 = new Combinedship(15, 2);*/

            Console.WriteLine(ship == ship2);
            Console.WriteLine(ship != ship2);

            /*Console.WriteLine(ship == ship3);
            Console.WriteLine(ship != ship3);
            Console.WriteLine();*/

            /*field.AddShip(10, 15, 1, ship, 'R');           
            field.AddShip(12, 13, 2, ship2, 'U');
            field.AddShip(2, 5, 3, ship3, 'R');
            field.AddShip(8, 6, 4, ship4, 'U');
            Console.Write(field.ToString());*/


        }
    }
}