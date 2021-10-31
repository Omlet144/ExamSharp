using System;
using System.Collections.Generic;

namespace ExamSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Declaration user1 = new Declaration();
           FillingTheDeclaration filling = new FillingTheDeclaration();
           Calculator calkul = new Calculator();
           filling.FillingInTheDeclaration(user1);
           calkul.PriceСalculation(user1);
           calkul.GetSalesReceipt(user1);
        }
       
    }
}
