using System;

namespace ExamSharp
{
  public class FillingTheDeclaration
    {  
        public FillingTheDeclaration(){}
        public void FillingInTheDeclaration(Declaration user1)
        {
            Random rnd = new Random();
            int Number = rnd.Next(100000, 999999);
            user1.NumDeclaration = Number;

            Console.Write("Enter your Name:\t");
            user1.Name = Console.ReadLine();

            Console.Write("Enter your Surname:\t");
            user1.Surename = Console.ReadLine();

            Console.Write("Enter your year of birth:\t");
            user1.YearOfBirth = int.Parse(Console.ReadLine()); 

            Console.Write("Enter your Month of birth:\t");
            user1.MonthOfBirth = int.Parse(Console.ReadLine()); 

            Console.Write("Enter your day of birth:\t");
            user1.DayOfBirth = int.Parse(Console.ReadLine()); 
            
            int ChooseTransport;
            Console.Write("Choose a mode of transport:\n1 - Motorbike\n2 - Automobile\n3 - A boat\n4 - Vessel\n5 - Helicopter\n6 - Airplane\n:");
            ChooseTransport = int.Parse(Console.ReadLine());
            if(ChooseTransport == 1){ user1.TypeTransport = "Motorbike";}
            else if(ChooseTransport == 2){ user1.TypeTransport = "Automobile";}
            else if(ChooseTransport == 3){ user1.TypeTransport = "A boat";}
            else if(ChooseTransport == 4){ user1.TypeTransport = "Vessel";}
            else if(ChooseTransport == 5){ user1.TypeTransport = "Helicopter";}
            else if(ChooseTransport == 6){ user1.TypeTransport = "Airplane";}
            else{Console.WriteLine("This type of transport does not exist");}
           
           if(ChooseTransport == 1 || ChooseTransport == 2 || ChooseTransport == 3 || ChooseTransport == 4 || ChooseTransport == 5 || ChooseTransport == 6){
            Console.Write("Vehicle make and model (example: Volkswagen Passat):\t");
            user1.VehicleMakeAndModel = Console.ReadLine(); 

            Console.Write("Enter your price transport($):\t");
            user1.PriceTransport = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nYour Sales receipt is ready");
            Console.WriteLine($"P.S. If the details on the check do not match your documents, the check is not valid!\n");
           }
           else{Console.WriteLine("Your sales receipt will not be printed! Delete the one that was created and try again!");}
        }
    }
}