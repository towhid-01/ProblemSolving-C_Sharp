using System.Collections.Generic;
namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> seqFrequency = new Dictionary<int, int>();

            for (int i = 0; i < seq.Length; i++){
                
                if (seqFrequency.ContainsKey(seq[i])){
                    seqFrequency[seq[i]]++; 
                }
                else seqFrequency[seq[i]] = 1; 
                
            }
            for (int i = 0; i < seq.Length; i++){
                if (seqFrequency[seq[i]] % 2 != 0) return seq[i];
            }
            return -1;
        }

    }
}