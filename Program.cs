using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            CancellationTokenSource cancel = new CancellationTokenSource();
            Task task1 = Task.Run(
                () =>
                {
                while (!cancel.IsCancellationRequested)
                {
                    t1.Func2();
                    Thread.Sleep(100);
                    }
                    Console.WriteLine("task1 finish.");
                },
                cancel.Token);
           
           
            Task task2 = Task.Run(() => { while (!cancel.IsCancellationRequested)
                {
                    t1.Func2();
                    Thread.Sleep(60);

                }
                Console.WriteLine("task2 finish.");
            }, cancel.Token);
            //第一次添加
            int i = 3;Console.WriteLine(i);

            //kdkldsffdadsfdas,测试
            
            Console.ReadKey();
            cancel.Cancel();
            Console.ReadKey();
        }
    }
    class Test
    {
        private object _objLock;
        public Test()
        {
            _objLock = new object();
        }

        public void Func1()
        {
            lock (_objLock)
            {
                Console.WriteLine($"Func1 {Thread.CurrentThread.ManagedThreadId}");
            }
        }
        public void Func2()
        {
            //lock (_objLock)
            {
                Console.WriteLine($">>>>>>>>>>>>> Func2 {Thread.CurrentThread.ManagedThreadId}");
                Func1();
                Console.WriteLine($"<<<<<<<<<<<<< Func2 {Thread.CurrentThread.ManagedThreadId}\n\n");
                
            }
        }
    }
}
