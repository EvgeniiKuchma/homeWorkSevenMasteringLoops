using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkSevenMasteringLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLoop;
            Console.Write("Введите количество повторений: ");
            numberLoop = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= numberLoop; i++)
            {
                Console.WriteLine("Итерация № " + i);
            }
        }
    }
}
