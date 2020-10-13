using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using 排序算法;
namespace Algorithm.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 3, 8, 1, 2, 15, 23, 55, 66, 22, 15, 45 };
            arr.Write();
            RadixSort.Sort(arr);
            arr.Write();
            Console.ReadLine();
        }
        
    }
    public static class ConsoleExtensions
    {
        //扩展一下int[] 方便直接输出元素
        public static void Write(this int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
