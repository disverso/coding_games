using System;
using System.Linq;

/// Shadows of the Knight - Episode 1 Solution
/// Link: https://www.codingame.com/training/medium/shadows-of-the-knight-episode-1

class Player
{
	static void Main(string[] args)
	{
		string[] inputs;
		inputs = Console.ReadLine().Split(' ');
		int W = int.Parse(inputs[0]); // width of the building.
		int H = int.Parse(inputs[1]); // height of the building.
		int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
		inputs = Console.ReadLine().Split(' ');
		int X0 = int.Parse(inputs[0]);
		int Y0 = int.Parse(inputs[1]);
		
		int maxX = W;
		int maxY = H;
		int minX = 0;
		int minY = 0;
		
		// game loop
		while (true)
		{
			string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
			
            if (bombDir.Contains('U'))
			{
				maxY = Y0;
				Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
			}
			else if (bombDir.Contains('D'))
			{
				minY = Y0;
				Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
			}
			
			if (bombDir.Contains('R'))
			{
				minX = X0;
				X0 = (int)Math.Truncate((maxX + minX) / 2.0);
			}
			else if (bombDir.Contains('L'))
			{
				maxX = X0;
				X0 = (int)Math.Truncate((maxX + minX) / 2.0);
			}

			Console.WriteLine(X0 + " " + Y0);
		}
	}
}
