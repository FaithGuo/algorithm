using System;
using System.Collections.Generic;
using System.Text;

namespace 排序算法
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public static class InsertionSort
    {
        /*
         每次选择一个元素，并且将这个元素和整个数组中的所有元素进行比较，然后插入到合适的位置
         时间复杂度 O(n^2)
         */
        public static void Sort(int[] arr)
        {
            int i, j;
            for (i = 1; i < arr.Length; i++)
            {
                int tmp = arr[i];
                for (j = i;j>0&&arr[j-1]>tmp ; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = tmp;
            }
        }
    }
}
