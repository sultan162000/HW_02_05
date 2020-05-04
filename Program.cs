using System;
using System.Threading;
using System.Threading.Tasks;


namespace Task_2
{
    static class Program
    {

        static void Main()
        {
            Console.SetWindowSize(70, 42);
 
            Matrix instance;
 
            for (int i = 0; i < 20; i++)
            {
                instance = new Matrix(i * 3, true);
                new Thread(instance.Shower).Start();
            }
           
        }

    }
}