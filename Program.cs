using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DD");
            List<int> numbers = Enumerable.Range(1, 10).ToList();

        }
        //[1,3,5,6]     2
        //[1,3,5,6,8]   2
        public int SearchInsert(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            SearchMe(nums, target, start, end);
        }
        public void SearchMe(int[] nums, int target, int start, int end)
        {
            if (start > end)
            {
                Console.WriteLine("Not found");
            }
            var middle = (end - start) / 2;

            if (nums[middle] == target)
            {
                Console.WriteLine();
            }
            if (nums[middle] > target)
            {
                SearchMe(nums, target, middle + 1, end);
            }
            if (nums[middle] < target)
            {
                SearchMe(nums, target, start, middle - 1);
            }

        }
    }
}