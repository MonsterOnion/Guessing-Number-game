namespace MyGame {

class Player {

	public int Win { get; set; }
	public int Lose { get; set; }

	public Player (int x, int y) {
		Win = Win;
		Lose = Lose;
	}

} // class player end

class GameLogic {

public void Start(string x) {
	Player p1 = new Player(0, 0);
	int playerWin = p1.Win;
	int playerLose = p1.Lose;

	Console.WriteLine("Hi " + x);

	while (true) {
		Console.Write("Your score is ");
		Console.Write("Win: " + Convert.ToString(playerWin) + " ");
		Console.Write("Lose: " + Convert.ToString(playerLose));

	try {
		Console.WriteLine("Enter your number here: ");
		int playerNumber = Convert.ToInt16(Console.ReadLine());

	bool gameResult = CalculateNumber(playerNumber);

	if (gameResult == true) {
		playerWin ++;
	} else {
		playerLose ++;
	} // condition end

	} catch (Exception) {
		Console.WriteLine("Oops, incorrect input, please enter the integer number");
	} // try and catch end

	} // loop end
} // Start function end

static bool CalculateNumber(int x) {
	Random rnd = new Random();
	int y = rnd.Next(0, 9);

	if (x == y) {
		Console.WriteLine("You win!");
		Console.WriteLine("Correct number is " + y);
		return true;
	} else {
		Console.WriteLine("You lose!");
		Console.WriteLine("Correct number is " + y);
		return false;
	} // condition end
} // calculate function end

} // logic end



class Program {

static void Main(string[] args) {
	Console.WriteLine("Welcome to guessing number, ");
	Console.WriteLine("The Game to guess number between 0 - 9, ");

GameLogic game = new GameLogic();

while (true) {

	try {
		Console.WriteLine("Enter your name here: ");
		string name = Console.ReadLine();

	if (name != " ") {
		game.Start(name);
	} // condition end
	} catch (Exception) {
		Console.WriteLine("Incorrect input, please enter correct format");
	} // catch end

} // Loop end

} // main end

} // program class end

}