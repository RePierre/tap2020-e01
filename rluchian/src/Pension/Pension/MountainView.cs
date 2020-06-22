using System;
using System.Collections.Generic;
using System.Text;

namespace Pension
{
    public class DoubleMountainView:Room
    {
        public DoubleMountainView(int number, DateTime Begin, DateTime End)
        {
            this.number = number;
            this.Begin = Begin;
            this.End = End;
        }
    }
}
}
