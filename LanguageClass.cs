using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class LanguageClass:ILanguage
    {
        public void Init()
        {
            Console.WriteLine("增加语言界面包");
        }

        public void SaidHello()
        {
            Console.WriteLine("English");
        }
    }
}
