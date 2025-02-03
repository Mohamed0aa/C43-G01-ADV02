using System.Collections;
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
                if (dic.ContainsKey(q[i])) { dic[q[i]]++; }
                else
                { dic.Add(q[i], 1); }
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

            #region q5:find num greater than q
            //int n, m;
            //int.TryParse(Console.ReadLine(), out n);
            //int.TryParse(Console.ReadLine(), out m);
            //int[] num= new int[n];
            //for (int i = 0;i < n;i++)
            //{
            //    int.TryParse(Console.ReadLine(), out num[i]);
            //}

            //for(int i = 0;i<m;i++)
            //{
            //    int q;
            //    int.TryParse(Console.ReadLine(), out q);

            //    Console.WriteLine( num.Count(x => x > q));
            //}

            #endregion


            #region q6
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] num1 = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out num1[i]);
            //}
            //int[] num2 = num1;
            //num2.Reverse();
            //for (int i = 0; i < n/2; i++)
            //{
            //    if (num1[i] != num2[n - i - 1])
            //    {
            //        Console.WriteLine("FALSE");
            //        return;
            //    }
            //}
            //Console.WriteLine("TRUE");
                #endregion




            
        }
    }
}
