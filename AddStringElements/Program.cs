using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddStringElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string[] nums;
            int sum=0;

            Console.WriteLine("enter the numbers: ");
            str = Console.ReadLine();

            nums = str.Split('+');

            for (int i=0;i<nums.Length;i++)         //could use foreach
            sum += int.Parse(nums[i]);

            Console.WriteLine("Sum of the items given : " + sum);
            Console.Read();
        }
    }
}
