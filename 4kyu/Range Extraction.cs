public class RangeExtraction{
    public static string Extract(int[] args){
        string ans="";
        int count = 0;
        for(int i = 0; i < args.Length; i++){
            if(i+1<args.Length  &&  (args[i] == args[i+1]-1)){
                count++;
            }
            else{
                if(count>=2){
                    string part1= args[i-count].ToString();
                    string part2= args[i].ToString();
                    ans+=part1+"-"+part2+",";
                    count=0;
                }
                else if(count==1){
                    string part1= args[i-1].ToString();
                    string part2= args[i].ToString();
                    ans+=part1+","+part2+",";
                    count=0;
                }
                else{
                    ans+=args[i].ToString()+",";
                }
            }
        }

        if(ans[ans.Length-1]==','){
            ans=ans.Remove(ans.Length-1);
        }
        return ans;
    }
}