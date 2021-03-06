﻿using System;

namespace chapter4_1
{
    class Program
    {
        static bool Containe (int[] a, int aLen, int b)
        {
            for(int i = 0; i < aLen; i++)
            {
                if (a[i] == b)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] Intersect(int[] a, int[] b)
        {
            int[] dup = new int[a.Length];

            int dupCnt = 0;

            for (int j = 0; j < a.Length; j++)
            {
                if (Containe(dup, dupCnt, a[j]))
                {
                    continue;
                }

                for (int i = 0; i < b.Length; i++)
                {
                    if (a[j] == b[i])
                    {
                        dup[dupCnt] = a[j];
                        dupCnt++;
                    }
                }
            }

            int[] ans = new int[dupCnt];
            for(int i = 0; i < dupCnt; i++)
            {
                ans[i] = dup[i];
            }

            return ans;
        }

        static void Print (int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] a1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] a2 = new int[5] { 3, 1, 5, 10, 11 };

            Print(Intersect(a1, a2));

            Console.ReadKey();
        }
    }
}
