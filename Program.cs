using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethods m = new MyMethods();

            int y = m.GetYears();
            m.GetInches(y);
            m.DisplayResults();


            Console.ReadLine();
        }
    }
}
