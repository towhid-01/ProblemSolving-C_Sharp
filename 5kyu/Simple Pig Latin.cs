using System;
using System.Text;

public class Kata
{
    public static string PigIt(string str)
    {
        StringBuilder s = new StringBuilder();
        StringBuilder s2 = new StringBuilder();

        for (int i = 0; i < str.Length; i++){
            if (str[i] == ' '){
                char temp = s2[0];
                s2.Remove(0, 1);

                
                s.Append(s2.ToString());
                s.Append(temp.ToString());
                s.Append("ay ");
              
                s2.Clear();
            }
            else{

                s2.Append(str[i]);
            }
        }

        if(s2.Length == 1)s.Append(s2.ToString());
        if (s2.Length > 1){
            char temp = s2[0];
            s2.Remove(0, 1);
           
            s.Append(s2.ToString());
            s.Append(temp.ToString()); 
            s.Append("ay");
        }

        return s.ToString();
    }
}
