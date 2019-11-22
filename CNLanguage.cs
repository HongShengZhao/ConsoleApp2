using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CNLanguage : ILanguage
    {
        public void SaidHello()
        {
            Console.WriteLine("中文");
        }
    }
}
