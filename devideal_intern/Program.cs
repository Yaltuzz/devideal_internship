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
            string dayOfBorrow;
            string yearOfBorrow;
            string monthOfBorrow;
            string dayOfReturn;
            string yearOfReturn;
            string monthOfReturn;
            Book book;
            int fee;

            while (running)
            {
                Console.WriteLine("Choose option: [1] calculate fee, [2] exit");
                command=Console.ReadLine();
                if (command.Equals("1"))
                {
                    Console.WriteLine("Please pick a book category [1] IT, [2] history," +
                        " [3] classic, [4] law, [5] philosophy, [6] medical");
                    typeOfBook = Console.ReadLine();
                    Console.WriteLine("Please, write the day of the borrow");
                    dayOfBorrow = Console.ReadLine();
                    Console.WriteLine("Please, write the month of the borrow");
                    monthOfBorrow = Console.ReadLine();
                    Console.WriteLine("Please, write the year of the borrow");
                    yearOfBorrow = Console.ReadLine();

                    Console.WriteLine("Please, write the day of the return");
                    dayOfReturn = Console.ReadLine();
                    Console.WriteLine("Please, write the month of the return");
                    monthOfReturn = Console.ReadLine();
                    Console.WriteLine("Please, write the year of the return");
                    yearOfReturn = Console.ReadLine();

                    switch (int.Parse(typeOfBook))
                    {
                        case 1:
                            book = new ItBook(int.Parse(yearOfBorrow), int.Parse(monthOfBorrow), 
                                int.Parse(dayOfBorrow),int.Parse(yearOfReturn), int.Parse(monthOfReturn),
                                int.Parse(dayOfReturn));
                            list.Add(book);
                            fee = book.CalcFee();
                            PrintInfo(fee);
                            break;
                        case 2:
                            book = new HistoryBook(int.Parse(yearOfBorrow), int.Parse(monthOfBorrow),
                                int.Parse(dayOfBorrow), int.Parse(yearOfReturn), int.Parse(monthOfReturn),
                                int.Parse(dayOfReturn));
                            list.Add(book);
                            fee = book.CalcFee();
                            PrintInfo(fee);
                            break;
                        default:
                            book = new OtherBook(int.Parse(yearOfBorrow), int.Parse(monthOfBorrow),
                                int.Parse(dayOfBorrow), int.Parse(yearOfReturn), int.Parse(monthOfReturn),
                                int.Parse(dayOfReturn));
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
