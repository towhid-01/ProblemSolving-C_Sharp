using System;
using System.Text;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    StringBuilder s = new StringBuilder();
    for (int i = 0; i<str.Length;i++){
      if(str[i] == '-' || str[i] == '_'){
          char c = Char.ToUpper(str[i+1]);
          s.Append(c.ToString());
        i++;
      }
      else {
        s.Append(str[i].ToString());
      }
    }
  
    return s.ToString();
  }
}