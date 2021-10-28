using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ExamSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Declaration user1 = new Declaration(18536, "Alex","Black", 27, "Avto", 650);
           Calculator calkul = new Calculator();
           calkul.PriceСalculation(user1);
           calkul.GetCheque(user1);
           

        }
    }
}
