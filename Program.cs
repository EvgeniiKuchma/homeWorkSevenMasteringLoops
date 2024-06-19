using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkSevenMasteringLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mеssage;
            int countRepeat;
            Console.Write("Введите количество повторений: ");
            countRepeat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свое сообщение: ");
            mеssage = Console.ReadLine();

            for (int i = 0; i < countRepeat; i++)
            {
                Console.WriteLine(mеssage + " " + (i + 1));
            }
        }
    }
}
