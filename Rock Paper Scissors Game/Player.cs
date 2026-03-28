namespace Rock_Paper_Scissors_Game;

public class Player
{
    public string Name { get; }
    public int Score { get; set; }
    
    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void AddPoint()
    {
        Score += 1;


    }
}