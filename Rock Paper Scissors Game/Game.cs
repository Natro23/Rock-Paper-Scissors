namespace Rock_Paper_Scissors_Game;

public class Game
{
    public string[] choices = ["rock", "paper", "scissors"];
    private Player player;
    private int computerScore;
    private Random random = new Random();
    
    public Game()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        player = new Player(name);
        computerScore = 0;
    }
    
    public string GetComputerChoice()
    {
        string choice =  choices[random.Next(0, choices.Length)];
        return choice;
    }
    
    public void DetermineWinner(string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It's a tie");
        }
        else if (playerChoice == "paper" && computerChoice == "rock")
        {
            Console.WriteLine("You Win !");
            player.AddPoint();
        }
        else if (playerChoice == "scissors" && computerChoice == "paper")
        {
            Console.WriteLine("You Win !");
            player.AddPoint();
        }
        else if (playerChoice == "rock" && computerChoice == "scissors")
        {
            Console.WriteLine("You Win !");
            player.AddPoint();
        }
        else
        {
            Console.WriteLine("You Lose");
            computerScore++;
        }
    }
    public void PlayRound()
    {
        Console.WriteLine("What is your choice?  (rock, paper, scissors)");
        string choice = Console.ReadLine().ToLower();
        string PcChoice = GetComputerChoice();
        Console.WriteLine($"Your choice: {choice} and your opponent: {PcChoice}");
        DetermineWinner(choice,PcChoice);
        Console.Write($"Your Score : {player.Score}. Your opponents score: {computerScore} ");
        Console.WriteLine("");
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Rock Paper Scissors Game!");
        while (true)
        {
            PlayRound();
            Console.WriteLine("Do you want to play again? y/n");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                Console.WriteLine($"Thanks for playing! Final score - You: {player.Score} Computer: {computerScore}");
                break;
            }


        }
        
    }
}