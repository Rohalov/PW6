using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public static class HashSetExtention
    {
        public static HashSet<int> FillRandomNum(this HashSet<int> array, int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                array.Add(rnd.Next());
            }
            return array;
        }
    }
}
