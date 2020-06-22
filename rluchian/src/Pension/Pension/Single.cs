using System;
using System.Collections.Generic;
using System.Text;

namespace Pension
{
    public class Single:Room
    {
        public Single(int number, DateTime Begin, DateTime End)
        {
            this.number = number;
            this.Begin = Begin;
            this.End = End;
        }
    }

}
}
