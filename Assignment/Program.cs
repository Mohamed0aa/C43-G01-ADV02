﻿using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    internal class Program
    {
        #region q1:Reverse_function
        public static void reverse(ArrayList arrayList)
        {
            int n = arrayList.Count;
            for (int i = 0; i < arrayList.Count; i++)
            {
                var temp = arrayList[i];
                arrayList[i] = arrayList[n - i - 1];
                arrayList[n - i - 1] = temp;
                if (i == n / 2) break;
            }
        }
        #endregion

        #region q4: FindUnique
        public static int FindUnique(string? q)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < q?.Length; i++)
            {
                if (dic.ContainsKey(q[i])) { dic[q[i]]++;  }
                else
                {  dic.Add(q[i], 1); }
            }
            for (int i = 0; i < q?.Length; i++)
            {
                if (dic[q[i]] == 1)
                {
                    
                    return i;
                }
            }
            return -1;
        }
        #endregion
        static void Main(string[] args)
        {
            #region q1: You are given an ArrayList containing a sequence of elements Reverse It
            //ArrayList arrayList = new ArrayList() { 'a',8,7,6,5,4,3,2,1};

            //reverse(arrayList);

            //for (int i = 0;i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            #endregion

            #region q2: Find Even numbers 
            //List<int> num = new List<int>() { 1,2,3,4,5,6};

            //List<int> EvenList = num.FindAll(x => x%2==0);

            //foreach (int num2 in EvenList)
            //{
            //    Console.WriteLine(num2);
            //}
            #endregion

            #region q3:implement a custom list called FixedSizeList
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>();
            //fixedSizeList.Addd(1);
            //fixedSizeList.Addd(2);
            //fixedSizeList.Addd(3);
            //fixedSizeList.Addd(4);
            //fixedSizeList.Get(3);
            #endregion

            #region q4:Given a string, find the first non-repeated character in it and return its index
            //string? q=Console.ReadLine();
            //Console.WriteLine( FindUnique(q));//1 o

            #endregion




        }
    }
}
