using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Graffiti on the fence - Solution
 * Link: https://www.codingame.com/training/easy/graffiti-on-the-fence
 **/
 
class Solution
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine()); // length of the fence
        int N = int.Parse(Console.ReadLine()); // number of reports
        int[] st = new int[N];
        int[] ed = new int[N];
        bool allPainted = true; // fence is all painted
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            st[i] = int.Parse(inputs[0]);
            ed[i] = int.Parse(inputs[1]);
        }
                
        shellSort_modified(ref st, ref ed); // sorting arrays

        int cur = 0; // current section of the fence

        for (int i = 0; i < N; i++)
        {
            if (cur < st[i]) {
                Console.WriteLine("{0} {1}", cur, st[i]);
                cur = ed[i];
                allPainted = false;
            } else if (cur < ed[i]) {
                cur = ed[i];
            }
        }
        
        if (cur < L) {
            Console.WriteLine("{0} {1}", cur, L);
            allPainted = false;
        }
        
        if (allPainted) {
            Console.WriteLine("All painted");
        }
    }
    
    // modified Shell sorting algorithm
    static void shellSort_modified(ref int[] arr_1, ref int[] arr_2)
    {
        int step = arr_1.Length / 2;
        while (step > 0)
        {
            int i, j;
            for (i = step; i < arr_1.Length; i++)
            {
                int value_1 = arr_1[i];
                int value_2 = arr_2[i];
                for (j = i - step; (j >= 0) && (arr_1[j] > value_1); j -= step) {
                    arr_1[j + step] = arr_1[j];
                    arr_2[j + step] = arr_2[j];
                }
                arr_1[j + step] = value_1;
                arr_2[j + step] = value_2;
            }
            step /= 2;
        }
    }
}
