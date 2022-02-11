using System;

namespace February_11th_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
             String str = "lawal";
           
             int n = str.Length;
           
             CheckPermutation(str, 0, n-1);
        }
        public static void CheckPermutation(string startIndex,int s1, int s2){
          
            if(s1 == s2)
          
            Console.WriteLine(startIndex);
          
            else{
                for(int i = s1; i <= s2; i++){
                  char temporaryCount;
          
            char[] characterArray = startIndex.ToCharArray();
           
            temporaryCount = characterArray[s1];
           
            characterArray[s1] = characterArray[s2];
           
            characterArray[s2] = temporaryCount;
  
                }
            }
            
        }
    }
}
 