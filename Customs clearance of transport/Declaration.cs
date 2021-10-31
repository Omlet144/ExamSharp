using System;

namespace ExamSharp
{
  public class Declaration
    {  
        public int NumDeclaration {get; set;}
        public string Name{get; set;}
        public string Surename {get; set;}
        public int YearOfBirth{get; set;}
        public int MonthOfBirth{get; set;}
        public int DayOfBirth{get; set;}
        public string VehicleMakeAndModel{get; set;}
        public string TypeTransport {get; set;}
        public int PriceTransport {get; set;}
        
       public Declaration()
        {
            this.NumDeclaration = 0;
            this.Name = "\0";
            this.Surename = "\0";
            this.YearOfBirth = 0;
            this.MonthOfBirth = 0;
            this.DayOfBirth = 0;
            this.TypeTransport = "\0";
            this.VehicleMakeAndModel = "\0";
            this.PriceTransport = 0;
        }
        public Declaration(int numdeclaration, string name, string surename, int yearofbirth, int monthofbirth, int dayofbirth, string typeTransport, string  vehicleMakeAndModel, int priceTransport)
        {
            this.NumDeclaration = numdeclaration;
            this.Name = name;
            this.Surename = surename;
            this.YearOfBirth = yearofbirth;
            this.MonthOfBirth = monthofbirth;
            this.DayOfBirth = dayofbirth;
            this.TypeTransport = typeTransport;
            this.VehicleMakeAndModel = vehicleMakeAndModel;
            this.PriceTransport = priceTransport;
        }
        public override string ToString()
        {
            return $"Nomber of Declaration:\t{NumDeclaration}\nName:\t\t{Name}\nSurename:\t{Surename}\nDate of Birth:\t\t{DayOfBirth}.{MonthOfBirth}.{YearOfBirth}\nYour Transport:\t{TypeTransport}: {VehicleMakeAndModel}\nPrice your Transport:\t{PriceTransport} $\n\n";
        }
    }
}