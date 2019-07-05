using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverFinal
{
    class Demo
    {

        int i;
        float j;

        public void SetData(int i, float j)
        {
            i = i;
            j = j;
        }

        public void Display()
        {
            Console.WriteLine(i + " " + j);
        }
    }
}
