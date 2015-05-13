using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOverviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htable=new Hashtable();
            htable.Add(1,10);
            htable[2] = 11;
            htable[3] = 12;


            Console.WriteLine(htable.Count);
            Console.Read();
        }
    }
}
