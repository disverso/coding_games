using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

// ANEO Sponsored Puzzle (Validators score: 90% passed).

class Solution
{
    static void Main(string[] args)
    {
        int speed = int.Parse(Console.ReadLine());
        int lightCount = int.Parse(Console.ReadLine());
        
        int[] distance = new int[lightCount];
        int[] duration = new int[lightCount];
        for (int i = 0; i < lightCount; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            distance[i] = int.Parse(inputs[0]);
            duration[i]= int.Parse(inputs[1]);
        }
        
        Console.Error.WriteLine("");
        
        int mxSpeed = speed;
        int mnSpeed = 0;
        bool search = true;
        
        while (search) {
            for (int i = 0; i < lightCount; i++){
                int maxSpeed, minSpeed;
                getSpeed(mxSpeed, distance[i], duration[i], out maxSpeed, out minSpeed);
                
                if (mxSpeed > maxSpeed) mxSpeed = maxSpeed;
                if (mnSpeed < maxSpeed) mnSpeed = minSpeed;
            }
            
            if (mnSpeed <= mxSpeed) {
                search = false;
            }
            mnSpeed = 0;
        }
        
        Console.WriteLine(mxSpeed);
    }
    
    static void getSpeed(int speed, int distance, int duration, out int maxSpeed, out int minSpeed) {
        
        double topSpeed = (double) speed * 1000.0 / 3600.0;
        double needTime = (double) distance / topSpeed;
        int iteration = (int) needTime / duration;
        if (iteration % 2 == 1) iteration++;
        
        
        double mxSpeed = (double) distance;
        double mnSpeed = (double) distance / duration;
        if (iteration > 1) {
            mxSpeed = (double) distance / (duration * iteration);
            mnSpeed = (double) distance / ((duration * (iteration + 1)) - 1);
        }
        maxSpeed = (int) Math.Floor(mxSpeed * 3600 / 1000);
        minSpeed = (int) Math.Ceiling(mnSpeed * 3600 / 1000);
    }
}
