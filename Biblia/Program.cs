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
                Console.WriteLine("1-Просмотр списка читателей, не вернувших книгу\n" +
                "2- Посмотреть перечень книг в библиотеке\n" +
                "3- Добавить новую запись\n" +
                "4- Отметить возврат книги\n");
                answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        fun.conclusionReaders();
                        break;
                    case 2:
                        fun.bookList();
                        break;
                    case 3:
                        fun.addingNewEntry();
                        break;
                    case 4:
                        fun.returnMarkBook();
                        break;
                }
                Console.WriteLine("Продолжить работу с системой - 1\nВыход из системы - любое значение ");
                answer = Convert.ToInt32(Console.ReadLine());
            } while (answer == 1);

            Console.ReadLine();
        }
    }
}