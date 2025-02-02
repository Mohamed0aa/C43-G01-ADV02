using System.Collections;

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
        }
    }
}
