using System;
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            int x = (int)Math.Round(Math.Log(n, i));
            if (Math.Pow(i, x) == n)
            {
                return (i, x);
            }
        }
        return null;
    }
}


 
