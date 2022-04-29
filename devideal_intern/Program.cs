using System;
using System.Collections.Generic;

namespace devideal_intern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            List<Book> list = new List<Book>();
            string command;
            string typeOfBook;
            string borrowDay;
            string borrowYear;
            string borrowMonth;
            string returnDay;
            string returnYear;
            string returnMonth;
            Book book;
            int fee;

            while (running)
            {
                Console.WriteLine("Choose option: [1] calculate fee, [2] exit");
                command=Console.ReadLine();
                if (command.Equals("1"))
                {
                    Console.WriteLine("Please pick a book category [1] it, [2] history," +
                        " [3] classic, [4] law, [5] philosophy, [6] medical");
                    typeOfBook = Console.ReadLine();
                    Console.WriteLine("Please, write the day of the borrow");
                    borrowDay = Console.ReadLine();
                    Console.WriteLine("Please, write the month of the borrow");
                    borrowMonth = Console.ReadLine();
                    Console.WriteLine("Please, write the year of the borrow");
                    borrowYear = Console.ReadLine();

                    Console.WriteLine("Please, write the day of the return");
                    returnDay = Console.ReadLine();
                    Console.WriteLine("Please, write the month of the return");
                    returnMonth = Console.ReadLine();
                    Console.WriteLine("Please, write the year of the return");
                    returnYear = Console.ReadLine();

                    switch (int.Parse(typeOfBook))
                    {
                        case 1:
                            book = new ItBook(int.Parse(borrowYear), int.Parse(borrowMonth), 
                                int.Parse(borrowDay),int.Parse(returnYear), int.Parse(returnMonth),
                                int.Parse(returnDay));
                            list.Add(book);
                            fee = book.CalcFee();
                            PrintInfo(fee);
                            break;
                        case 2:
                            book = new HistoryBook(int.Parse(borrowYear), int.Parse(borrowMonth),
                                    int.Parse(borrowDay), int.Parse(returnYear), int.Parse(returnMonth),
                                    int.Parse(returnDay));
                            list.Add(book);
                            fee = book.CalcFee();
                            PrintInfo(fee);
                            break;
                        default:
                            book = new OtherBook(int.Parse(borrowYear), int.Parse(borrowMonth),
                                int.Parse(borrowDay), int.Parse(returnYear), int.Parse(returnMonth),
                                int.Parse(returnDay));
                            list.Add(book);
                            fee = book.CalcFee();
                            PrintInfo(fee);
                            break;
                    }
                }
                else
                {
                    running = false;
                }
            }
        }

        public static void PrintInfo(int fee)
        {
            if (fee > 0)
            {
                Console.WriteLine("borrower penalty fee is " + fee + "PLN");
            }
            else
            {
                Console.WriteLine("borrower has no fee to pay");
            }
        }
    }
}
