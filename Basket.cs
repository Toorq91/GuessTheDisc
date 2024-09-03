namespace GuessTheDisc
{
    public class Basket
    {
        public int Distance { get; private set; }
        public string Direction { get; private set; }

        private static Random random = new Random();

        public Basket()
        {
            Distance = random.Next(50, 151); // Avstand i meter (50-150)
            Direction = new[] { "left", "straight", "right" }[random.Next(0, 3)]; // Retning på kurven
        }

        public override string ToString()
        {
            return $"Distance: {Distance}m, Direction: {Direction}";
        }
    }

    public class Disc
    {
        public int Speed { get; private set; }
        public int Glide { get; private set; }
        public int Turn { get; private set; }
        public int Fade { get; private set; }

        public Disc(int speed, int glide, int turn, int fade)
        {
            Speed = speed;
            Glide = glide;
            Turn = turn;
            Fade = fade;
        }

        public override string ToString()
        {
            return $"Speed: {Speed}, Glide: {Glide}, Turn: {Turn}, Fade: {Fade}";
        }
    }
}