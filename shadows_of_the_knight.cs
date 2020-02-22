using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
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

            if (bombDir == "U") {
                
                maxY = Y0;
                Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
                
            } else if (bombDir == "UR") {
                
                minX = X0;
                maxY = Y0;
                X0 = (int)Math.Truncate((maxX + minX) / 2.0);
                Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
                
            } else if (bombDir == "R") {
                
                minX = X0;
                X0 = (int)Math.Truncate((maxX + minX) / 2.0);
                
            } else if (bombDir == "DR") {
                
                minX = X0;
                minY = Y0;
                X0 = (int)Math.Truncate((maxX + minX) / 2.0);
                Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
                
            } else if (bombDir == "D") {
                
                minY = Y0;
                Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
                
            } else if (bombDir == "DL") {
                
                maxX = X0;
                minY = Y0;
                X0 = (int)Math.Truncate((maxX + minX) / 2.0);
                Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
                
            } else if (bombDir == "L") {
                
                maxX = X0;
                X0 = (int)Math.Truncate((maxX + minX) / 2.0);
                
            } else if (bombDir == "UL") {
                
                maxX = X0;
                maxY = Y0;
                X0 = (int)Math.Truncate((maxX + minX) / 2.0);
                Y0 = (int)Math.Truncate((maxY + minY) / 2.0);
                
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // the location of the next window Batman should jump to.
            Console.WriteLine(X0 + " " + Y0);
        }
    }
}
