namespace RockPapperScissors {
    public class ComputerPlayer : IPlayer{
        public Choice GetChoice(){
            Random _rnd = new Random();
            Choice p_2 = (Choice)_rnd.Next(0, 3);
            return p_2;
        }
    }
}
