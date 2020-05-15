
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZMEIKKA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Osnova XYI = new Osnova();
           do
           {
                XYI.Figura_vibor();
                XYI.AI_Figura_vibor();
                XYI.Ender_mir();
           } while (XYI.end);
        }
    }
}
