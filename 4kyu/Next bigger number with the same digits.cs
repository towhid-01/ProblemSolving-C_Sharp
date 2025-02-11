using System;
public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        char[] biggerNumber = n.ToString().ToCharArray();
        int i;
        for (i = biggerNumber.Length - 2; i >= 0; i--)
        {
            if (biggerNumber[i] < biggerNumber[i + 1])
                break;
        }

        if (i < 0) return -1;
        int j;
        for (j = biggerNumber.Length - 1; j > i; j--)
        {
            if (biggerNumber[j] > biggerNumber[i])
                break;
        }

        char temp = biggerNumber[i];
        biggerNumber[i] = biggerNumber[j];
        biggerNumber[j] = temp;
        Array.Reverse(biggerNumber, i + 1, biggerNumber.Length - (i + 1));

        return long.Parse(new string(biggerNumber));
    }
}
