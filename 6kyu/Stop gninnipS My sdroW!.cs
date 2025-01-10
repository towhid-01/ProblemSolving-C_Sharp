using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string s="",s2="";
   for(int j = 0 ; j<sentence.Length;j++){
     if(sentence[j]!=' ')s+=sentence[j];
     else{
       if(s.Length>=5){
         if(j!=sentence.Length-1){
           
         for(int i=s.Length-1;i>=0;i--)s2+=s[i];
         }
         else for(int i=s.Length-1;i>=0;i--)s2+=s[i];
         s="";
         s2+=" ";
       }
       else {s2+=s;s2+=" ";s="";}
     }
   }
      if(s.Length>=5){
         for(int i=s.Length-1;i>=0;i--)s2+=s[i];
         }
    else if(s.Length>0){s2+=s;}
      
      return s2;
    
    return sentence;
  }
}