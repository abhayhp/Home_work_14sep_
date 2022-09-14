using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_14sep_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SE obj = new SE();

            obj.assignValues_s();
            obj.assignValues_e();

            Console.WriteLine(obj.displayValues_s());
            Console.WriteLine(obj.displayValues_e());
        }
    }
}
