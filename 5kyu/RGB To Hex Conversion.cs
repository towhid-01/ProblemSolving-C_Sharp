using System.Text;
public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    StringBuilder s = new StringBuilder();

    if(r>255)r=255;
    if(g>255)g=255;
    if(b>255)b=255;    
    if(r<0)r=0;
    if(g<0)g=0;
    if(b<0)b=0;

    int firstHigh = r/16;
    int firstLow = r%16;
    int secondHigh = g/16;
    int secondLow = g%16;
    int thirdHigh = b/16;
    int thirdLow = b%16;

    s.Append(firstHigh.ToString("X"));
    s.Append(firstLow.ToString("X"));
    s.Append(secondHigh.ToString("X"));
    s.Append(secondLow.ToString("X"));
    s.Append(thirdHigh.ToString("X"));
    s.Append(thirdLow.ToString("X"));
    
    return s.ToString();
  }
}