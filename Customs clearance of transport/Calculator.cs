using System;
using System.IO;

namespace ExamSharp
{
  public class Calculator
  {
    int Price{get;set;}
    int ImportDuty {get;set;}
    int ExciseDuty {get;set;}
    int VAT {get;set;}
   

    public Calculator()
    {
      this.Price = 0;
      this.ImportDuty = 95;
      this.ExciseDuty = 100;
      this.VAT =  0;
    }
      public void PriceСalculation(Declaration declaration)
      {
        this.VAT = (declaration.PriceTransport * 30)/100;
        Price = declaration.PriceTransport + this.ImportDuty + this.ExciseDuty + this.VAT;
      }
      public override string ToString()
      {
        return $"Import Duty:\t{ImportDuty}\nExcise Duty:\t{ExciseDuty}\nVAT:\t\t\t{VAT}\nCost with customs clearance:\t{Price} $\n";
      }
        public void GetSalesReceipt (Declaration declaration)
        {   
          File.WriteAllText("SAlES RECEIPT.txt","SAlES RECEIPT\n\n");
          File.AppendAllText("SAlES RECEIPT.txt",declaration.ToString());
          File.AppendAllText("SAlES RECEIPT.txt",this.ToString());
        }
  }
}