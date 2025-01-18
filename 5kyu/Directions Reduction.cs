using System;
using System.Collections.Generic;

public class DirReduction {

    public static string[] dirReduc(string[] arr)
    {
        
        Stack<string> str = new Stack<string>();
        // Dictionary to store opposite directions
        Dictionary<string, string> oppositeDirections = new Dictionary<string, string> {
            { "NORTH", "SOUTH" },
            { "SOUTH", "NORTH" },
            { "EAST", "WEST" },
            { "WEST", "EAST" }
        };

        for (int i = 0; i < arr.Length; i++) {
        
            if (oppositeDirections.ContainsKey(arr[i])) {
                
                if (str.Count > 0 && str.Peek() == oppositeDirections[arr[i]]) {

                    str.Pop(); 
                } 
                else  str.Push(arr[i]);
            } 
            else str.Push(arr[i]);
        }

        string[] s = new string[str.Count];
        int i = 0;

        foreach (var x in str) {
            s[i++] = x;
        }

        Array.Reverse(s);

        return s;
    }
}
