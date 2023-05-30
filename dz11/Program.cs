namespace dz11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" title of piece: ");
            string t = Console.ReadLine();
            Console.Write("Enter PIB of author of piece: ");
            string PIB = Console.ReadLine();
            Console.Write("Enter genre of piece ( Drama,  Melodrama, Tragedy, Comedy, Historical, Farce, Experimental, Morality, : ");
            string g = Console.ReadLine();
            Console.Write("Enter year of piece: ");
            int y = int.Parse(Console.ReadLine());

            using (Piece piece = new Piece(t, PIB, g, y))
            {
                piece.Show();
            }


            Console.Write(" title of shop: ");
            string ti = Console.ReadLine();
            Console.Write(" address of shop: ");
            string ad = Console.ReadLine();
            Console.Write(" type of shop (Grocery,  Clothing, Shoes): ");
            string type = Console.ReadLine();

            using (Shop shop = new Shop(ti, ad, type))
            {
                shop.Show();
            }

        }
    }
}