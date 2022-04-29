using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devideal_intern
{
    class OtherBook:Book
    {
        private const int fee = 2;

        public OtherBook(int yearOfBorrow, int monthOfBorrow, int dayOfBorrow,
            int yearOfReturn, int monthOfReturn, int dayOfReturn):base()
        {
            this.DateOfBorrow = new DateTime(yearOfBorrow, monthOfBorrow, dayOfBorrow);
            this.DateOfReturn = new DateTime(yearOfReturn, monthOfReturn, dayOfReturn);
        }
        public override int CalcFee()
        {
            TimeSpan differenceTime = this.DateOfReturn - this.DateOfBorrow;
            int differenceDay = differenceTime.Days;
            int calcFee = (differenceDay - DaysForReturn) * fee;
            return calcFee;
        }
    }
}
