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

            #region q2:
            //List<int> num = new List<int>() { 1,2,3,4,5,6};

            //List<int> EvenList = num.FindAll(x => x%2==0);

            //foreach (int num2 in EvenList)
            //{
            //    Console.WriteLine(num2);
            //}
            #endregion
        }
    }
}
