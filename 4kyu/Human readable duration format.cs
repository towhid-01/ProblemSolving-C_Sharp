using System.Collections.Generic;
using System.Linq;
public class HumanTimeFormat{
  public static string formatDuration(int seconds){
        if(seconds == 0) return "now";
        int years = seconds / 31536000;
        int days = (seconds % 31536000) / 86400;
        int hours = (seconds % 86400) / 3600;
        int minutes = (seconds % 3600) / 60;
        int second = seconds % 60;
        List<string> customizableStringArray = new List<string>();
        if(years > 0) customizableStringArray.Add(years + (years > 1 ? " years" : " year"));
        if(days > 0) customizableStringArray.Add(days + (days > 1 ? " days" : " day"));
        if(hours > 0) customizableStringArray.Add(hours + (hours > 1 ? " hours" : " hour"));
        if(minutes > 0) customizableStringArray.Add(minutes + (minutes > 1 ? " minutes" : " minute"));
        if(second > 0) customizableStringArray.Add(second + (second > 1 ? " seconds" : " second"));
        if(customizableStringArray.Count == 0) return "now"; 
        if(customizableStringArray.Count == 1) return customizableStringArray[0];
        
        string ans = string.Join(", ", customizableStringArray.Take(customizableStringArray.Count - 1)) + " and " + customizableStringArray.Last();
        
        return ans;
  }
}
