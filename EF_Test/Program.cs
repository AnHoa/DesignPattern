using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEntities db = new TestEntities();

            var dataset = db.SP_Get_EmpInfo(1);

            foreach (var tb in dataset)
            {
                Console.WriteLine(tb.Name + " " + tb.BirthDay.ToString());
            }
        }
    }
}
