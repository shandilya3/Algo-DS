//Given an array of integers, find two numbers such that they add up to a specific target number.
using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
       public static  int  i = 0;
        public static void Main(string[] args)
        {
            Program obj = new Program();
           int[] numbers ={1,4,45,6,8,10};
           int target =16;
          int[] res= obj.twoSum(numbers ,  target);
          foreach(int i in res)
          {
            Console.WriteLine(numbers[i]);
          }
        
        }
     
        public int[] twoSum(int[] numbers, int target) {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                int[] result = new int[2];
            
                for (int i = 0; i < numbers.Length; i++) {
                    if (dict.ContainsKey(numbers[i])) {
                    int index = dict[numbers[i]];
                        result[0] = index ;
                        result[1] = i;
                        break;
                    } else {
                        dict.Add(target - numbers[i], i);
                    }
                }
            
            return result;
        }  
      
    }
}
