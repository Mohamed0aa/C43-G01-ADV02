using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        List<T>? list;
        int co = 0;
        int Size;
        public FixedSizeList()
        {
            
            int.TryParse(Console.ReadLine(),out Size);
            list = new List<T>(Size);
        }
        public  void Addd(T Value)
        {
            if ((Value is not null)&& co<Size )
            {
                list?.Add(Value);
                co++;
            }
            else
            {
                Console.WriteLine("Try_Again");
            }
        }

        public void Get(int index)
        {
            if ((list is not null) &&index>=0 &&index<co)
            {
                Console.WriteLine(list[index]);
                
            }
            else
            {
                Console.WriteLine("invalid indices");
            }
            
        }
    }
}
