public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int[] newArray = new int[arr.Length];
    int j=0;
    for(int i=0;i<arr.Length;i++){
      if(arr[i] > 0){newArray[j]=arr[i];j++;}
    }
    int n = newArray.Length;
    for(int i=j;i<arr.Length-n;i++){
       newArray[i]=0;
    }

    return newArray;
  }
}