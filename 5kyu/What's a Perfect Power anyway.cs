using System;
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            int power = (int)Math.Round(Math.Log(n, i));
            if (Math.Pow(i, power) == n)
            {
                return (i, power);
            }
        }
        return null;
    }
}


 
