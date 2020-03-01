using System;

///
/// Power of Thor - Episode 1 Solution
/// Link: https://www.codingame.com/ide/puzzle/power-of-thor-episode-1
///

class Player
{
	static void Main(string[] args)
	{
		string[] inputs = Console.ReadLine().Split(' ');
		int lightX = int.Parse(inputs[0]); // the X position of the light of power
		int lightY = int.Parse(inputs[1]); // the Y position of the light of power
		int initialTx = int.Parse(inputs[2]); // Thor's starting X position
		int initialTy = int.Parse(inputs[3]); // Thor's starting Y position
		string output = "";
		
		// game loop
		while (true)
		{
			int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
			if (lightY < initialTy)
			{
				initialTy--;
				output += "N";
			}
			else if (lightY > initialTy)
			{
				initialTy++;
				output += "S";
			}

			if (lightX > initialTx)
			{
				initialTx++;
				output += "E";
			}
			else if (lightX < initialTx)
			{
				initialTx--;
				output += "W";
			}

			Console.WriteLine(output);
			output = "";
		}
	}
}
