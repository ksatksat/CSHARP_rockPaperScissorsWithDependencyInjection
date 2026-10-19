namespace RockPapperScissors {
    public class HumanPlayer : IPlayer{
        public Choice GetChoice(){
            Choice p_1;
            do
            {
                Console.Write("Enter Choice (R)ock, (P)apper, or (S)cissors: ");
                string input = Console.ReadLine().ToUpper();
                if (input == "R")
                {
                    p_1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    p_1 = Choice.Papper;
                    break;
                }
                else if (input == "S")
                {
                    p_1 = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice Try Again ... ");
                }
            } while (true);
            return p_1;
        }
    }
}