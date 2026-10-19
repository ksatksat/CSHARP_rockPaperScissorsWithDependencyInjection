using System;
namespace RockPapperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());
            //you can make esaly change players in this constructor type dependency injection
            //GameManager gm = new GameManager(new ComputerPlayer(), new ComputerPlayer());
            do
            {
                RoundResult result = gm.PlayRound();
                if (result == RoundResult.Player_1_wins)
                {
                    Console.WriteLine("Player 1 - Wins !");
                }
                else if (result == RoundResult.Player_2_wins)
                {
                    Console.WriteLine("Player 2 - Wins !");
                }
                else
                {
                    Console.WriteLine("It's a Draw !");
                }
                Console.WriteLine("Play Again (Y/N) ?");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Exiting from game ...");
        }
    }
    class GameManager
    {
        private IPlayer _player_1;
        private IPlayer _player_2;
        public GameManager(IPlayer player_1, IPlayer player_2)//constructor type dependency injection
        {
            _player_1 = player_1;
            _player_2 = player_2;
        }
        public RoundResult PlayRound()
        {
            Choice p_1 = _player_1.GetChoice();
            Choice p_2 = _player_2.GetChoice();
            Console.WriteLine($"Player 1 picks {p_1.ToString()}. \nPlayer 2 picks {p_2.ToString()}.");
            if (p_1 == p_2)
            {
                return RoundResult.Draw;
            }
            if (p_1 == Choice.Rock && p_2 == Choice.Scissors
            || p_1 == Choice.Papper && p_2 == Choice.Rock
            || p_1 == Choice.Scissors && p_2 == Choice.Papper)
            {
                return RoundResult.Player_1_wins;
            }
            return RoundResult.Player_2_wins;
        }
    }
    public enum RoundResult
    {
        Player_1_wins,
        Player_2_wins,
        Draw
    }
    public enum Choice
    {
        Rock,
        Papper,
        Scissors
    }
}