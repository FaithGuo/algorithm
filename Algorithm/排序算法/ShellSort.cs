using System;
using System.Collections.Generic;
using System.Text;

namespace 排序算法
{
    /// <summary>
    /// 希尔排序
    /// </summary>
    public static class ShellSort
    {
        /*
         这个是插入排序的修改版，根据步长由长到短分组，进行排序，直到步长为1为止，属于插入排序的一种。
         希尔排序时间复杂度的指数具体数值目前是比较模糊的，并没有一个统一的取值，它取决于增量。
         但已知的就是指数不是平方级的，即不是O(n^2)，而是O(n^m(m>1<2))也就是说指数m不会大于等于2是介于[1,2)半闭半开区间。
         */
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n/2; gap >0 ; gap/=2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >=gap&&arr[j-gap]>temp; j-=gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }
    }
}
