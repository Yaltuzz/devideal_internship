using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devideal_intern
{
    abstract class Book
    {
        protected int DaysForReturn {get;set;}
        protected DateTime DateOfBorrow { get; set; }
        protected DateTime DateOfReturn { get; set; }
        public Book()
        {
            this.DaysForReturn = 1;
        }
        public abstract int CalcFee();
    }
}
