public static class Kata
{
  public static int Solution(int value)
  {
    int count=0;
    if(value<0)return 0;
    for(int i =1;i<value;i++){
      if(i%3==0 && i%5==0)count+=i;
      else if(i%3==0)count+=i;
      else if(i%5==0)count+=i;
    }
    return count;
    return 0;
  }
}