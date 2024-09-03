/*
1.Kommer opp random kurv som har random lengde og står enten til venstre/rett fram/høyre.
2. Brukeren må lage egen disc basert på lengde av kurv og hvor den har tenkt til å lande, eks: (Kurv er 80m og inn til høyre,
    så må bruker lage en disc som tilsier at discen skal klare å flippe opp til turn og holden eller holde en annhayser "mellom 3-6 speed, 4-6 glide, -2--4 turn, 1-2 fade").

Speed: 1 - 14
Glide: 1 - 7
Turn: 1--5
Fade: 0 - 5
*/

namespace GuessTheDisc
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.EvaluateShot();
        }
    }
}