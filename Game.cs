namespace GuessTheDisc
{
    public class Game
    {
        public Basket Basket { get; private set; }
        public Disc UserDisc { get; private set; }

        public Game()
        {
            Basket = CreateRandomBasket();
            UserDisc = GetUserDisc();
        }

        public void EvaluateShot()
        {
            Console.WriteLine("Evaluating the shot...");

            // Simulering av hvor langt discen går basert på speed og glide
            int expectedDistance = UserDisc.Speed * UserDisc.Glide * 2; // Enkel modell for distanse

            // Bestem retning basert på turn og fade
            bool directionMatch = false;
            if (Basket.Direction == "left" && UserDisc.Turn < -2)
            {
                directionMatch = true;
            }
            else if (Basket.Direction == "right" && UserDisc.Turn > 0)
            {
                directionMatch = true;
            }
            else if (Basket.Direction == "straight" && UserDisc.Turn == 0)
            {
                directionMatch = true;
            }

            // Gi tilbakemelding
            if (expectedDistance >= Basket.Distance && directionMatch)
            {
                Console.WriteLine("Great shot! The disc is likely to land near the basket.");
            }
            else
            {
                Console.WriteLine("The disc might not reach the basket, or it may not land in the right direction.");
            }
        }

        private Basket CreateRandomBasket()
        {
            Basket basket = new Basket();
            Console.WriteLine($"A random basket has been generated: {basket}");
            return basket;
        }

        private Disc GetUserDisc()
        {
            Console.Write("Enter speed (e.g., 1-14): ");
            int speed = int.Parse(Console.ReadLine());

            Console.Write("Enter glide (e.g., 1-7): ");
            int glide = int.Parse(Console.ReadLine());

            Console.Write("Enter turn (e.g., +1 to -5): ");
            int turn = int.Parse(Console.ReadLine());

            Console.Write("Enter fade (e.g., 0-5): ");
            int fade = int.Parse(Console.ReadLine());

            Disc disc = new Disc(speed, glide, turn, fade);
            Console.WriteLine($"You have created a disc: {disc}");
            return disc;
        }
    }
}