using System;
using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        List<int> vec = new List<int>();  
        
        int up = 0, lower = array.Length - 1, left = 0, right = array[0].Length - 1;
        
        while (up <= lower && left <= right){
           
            for (int j = left; j <= right; j++)  vec.Add(array[up][j]);  
                
            up++; 

            for (int i = up; i <= lower; i++) vec.Add(array[i][right]); 

            right--;  

            if (up <= lower){
                for (int j = right; j >= left; j--)vec.Add(array[lower][j]);  
                lower--;  
            }

           
            if (left <= right){
                for (int i = lower; i >= up; i--)vec.Add(array[i][left]);  
                left++;  
            }
        }

        return vec.ToArray(); 
    }
}