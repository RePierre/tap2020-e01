using System;
using System.Collections.Generic;
using System.Text;

namespace Pension
{
    public class DoubleSimpleView:Room
    {
        public SimpleView(int number, DateTime Begin, DateTime End)
        {
            this.number = number;
            this.Begin = Begin;
            this.End = End;
        }
    }

}
}
