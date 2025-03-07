using System.Collections.Generic;

public class Kata
{
    public static List<string> GetPINs(string observed)
    {
        var keysAdjacents = new Dictionary<char, List<char>>
        {
            {'1', new List<char> {'1', '2', '4'}},
            {'2', new List<char> {'1', '2', '3', '5'}},
            {'3', new List<char> {'2', '3', '6'}},
            {'4', new List<char> {'1', '4', '5', '7'}},
            {'5', new List<char> {'2', '4', '5', '6', '8'}},
            {'6', new List<char> {'3', '5', '6', '9'}},
            {'7', new List<char> {'4', '7', '8'}},
            {'8', new List<char> {'5', '7', '8', '9', '0'}},
            {'9', new List<char> {'6', '8', '9'}},
            {'0', new List<char> {'0', '8'}}
        };

        List<string> result = new List<string> { "" };

        foreach (char digit in observed)
        {
            List<string> temp = new List<string>();

            foreach (string index in result)
            {
                foreach (char c in keysAdjacents[digit])
                {
                    temp.Add(index + c);
                }
            }
            result = temp;
        }

        return result;
    }
}
