namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player player1 = new Player("SteeCow");
            Player player2 = new Player("DoggoSilva");

            //// start the audio and rendering system
            //audioSystem.StartGame();
            //renderingEngine.StartGame();

            //// spawn players
            //player1.StartGame();
            //player2.StartGame();

            GameEventManager.TriggerGameStart();

            // Shutdown the game after the user hits a key

            Console.Read();

            //renderingEngine.GameOver();
            //audioSystem.GameOver();

            //// remove players
            //player1.GameOver();
            //player2.GameOver();
            GameEventManager.TriggerGameOver();
        }
    }
}
