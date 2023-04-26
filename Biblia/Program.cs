using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functional fun = new Functional();
            int answer = 0;
            do
            {
                Console.WriteLine("1-Просмотр списка читателей, не вернувших книгу" +
                    "2- ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (answer == 1);
            //fun.conclusionReaders();
            fun.bookList();
            Console.ReadLine();
        }
    }
}
