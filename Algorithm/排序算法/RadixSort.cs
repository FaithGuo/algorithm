using System;
using System.Collections.Generic;
using System.Text;

namespace 排序算法
{
    /// <summary>
    /// 基数排序
    /// </summary>
    public static class RadixSort
    {
        /*
         基数排序是一种非比较型整数排序算法，其原理是将整数按位数切割成不同的数字，然后按每个位数分别比较。
         排序过程是将所有待比较数值统一为同样的数位长度，数位较短的数前面补零，然后从最低位开始，依次进行一次排序。
         这样从最低位排序一直到最高位排序完成以后, 数列就变成一个有序序列。
         基数排序法是属于稳定性的排序，其时间复杂度为O (nlog(r)m)，其中r为所采取的基数，而m为堆数，
         在某些时候，基数排序法的效率高于其它的稳定性排序法。
         */

        private static int GetMax(int[] arr)
        {
            int mx = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > mx)
                    mx = arr[i];
            }
            return mx;
        }

        private static void CountSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output=new int[n];
            int i;
            int[] count = new int[10];

            for (i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = n-1; i >=0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for ( i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }

        }

        public static void Sort(int[] arr)
        {
            int m = GetMax(arr);
            for (int exp = 1; m/exp>0; exp*=10)
            {
                CountSort(arr, exp);
            }
        }
    }
}
