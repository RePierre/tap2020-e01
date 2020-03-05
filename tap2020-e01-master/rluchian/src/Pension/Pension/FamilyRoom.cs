using System;
using System.Collections.Generic;
using System.Text;

namespace Pension
{
    public class FamilyRoom:Room
    {
        public FamilyRoom(int number, DateTime Begin, DateTime End)
        {
            this.number = number;
            this.Begin = Begin;
            this.End = End;
        }
    }
}
