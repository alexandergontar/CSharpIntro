using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBtest1
{
    public class Counter
    {
        public static int count;
        public void add() 
        {
            count++;
        }
        public string getCount() 
        {
            return count.ToString();
        }
    }
}
