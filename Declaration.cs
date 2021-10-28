using System;

namespace ExamSharp
{
  public class Declaration
    {  
        public int NumDeclaration {get; set;}
       public string Name{get; set;}
       public string Surename {get; set;}
       public int Age{get; set;}
        public string TypeTransport {get; set;}
        public int PriceTransport {get; set;}


        
       public Declaration()
        {
            this.NumDeclaration = 0;
            this.Name = "\0";
            this.Surename = "\0";
            this.Age = 0;
            this.TypeTransport = "\0";
            this.PriceTransport = 0;
        }
        public Declaration(int numDeclaration, string name, string surename, int age, string typeTransport, int priceTransport)
        {
            this.NumDeclaration = numDeclaration;
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
            this.TypeTransport = typeTransport;
            this.PriceTransport = priceTransport;
        }
        public override string ToString()
        {
            return $"Nomber of Declaration:\t{NumDeclaration}\nName:\t{Name}\nSurename:\t{Surename}\nAge:\t{Age}\nYour Transport:\t{TypeTransport}\nPrice your Transport:\t{PriceTransport} $\n\n";
        }
    }
}