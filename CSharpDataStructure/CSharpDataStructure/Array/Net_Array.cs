using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructure.Array
{
    /// <summary>
    /// .Net Framework에서 제공하는 동적배열.
    /// </summary>
    internal class Net_Array
    {
        public void Run()
        {
            List<int> a = new List<int>();
            for(int i = 0; i <= 17; i++)
            {
                a.Add(i);
                Console.WriteLine("{0}: {1}", i, a.Capacity); // 2배씩 증가.
            }    
        }
    }
}
