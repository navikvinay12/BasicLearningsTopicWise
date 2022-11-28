using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Sample
    {
        private int value;
        public void SetValue(int v)
        {
            value = v;
        }
        public void PrintValue()
        {
            Console.WriteLine("Value : "+ value);
        }
        public void AddObj(Sample S1,Sample S2)
        {
            value= S1.value+S2.value;
        }
    }
}
//As we know that we can pass primitive (basic) data types in methods as arguments. 
//    Similarly, we can pass objects in methods too.