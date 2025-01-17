using System;
using System.Collections.Generic;
public class SnailSolution
{
   public static int[] Snail(int[][] array)
   {
    List<int> vec = new List<int>();
        int up = 0,lower = array.length - 1,left = 0,right = array[0].length - 1,
        i = up,
        j = left;

    while (1) {
        if (up++ > lower) break;

        for (; j < right; j++) vec.Add(array[i][j]);
        if (right-- < left) break;

        for (; i < lower; i++) vec.Add(array[i][j]);
        if (lower-- < up) break;

        for (; j > left; j--) vec.Add(array[i][j]);
        if (left++ > right) break;

        for (; i > up; i--) vec.Add(array[i][j]);
    }

    vec.Add(array[i][j]);
    return vec;
   }
}