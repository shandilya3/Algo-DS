using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(true==IsHappy(20))
            {
                Console.WriteLine("Happy Number ");
            }
            else
            {
                Console.WriteLine("This is not a Happy Number");
            }
        }
        public  static Boolean IsHappy(int n )
        {
         HashSet<int> set = new HashSet<int>();
            while(!set.Contains(n))
            {
                set.Add(n);
                n = GetSum(n);
                if(n==1)
                   return true;
            }           
            return false;
        }
        public static int GetSum(int n)
        {
            int sum = 0;
            while(n>0)
            {
                sum = sum+ (n%10) * (n%10);
                Console.WriteLine("Sum"+sum);
                n = n/10;
                Console.WriteLine("n ="+n);
            }
            return sum;
        }
    }
}
