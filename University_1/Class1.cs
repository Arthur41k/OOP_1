using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace University_1
{
    public class LandDinosaurus:IDino
    {
        
        string Name;
        string type;
        string Move;
     
        public void ReadValues()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            

            if (Name == null)
            {
                Console.Write("Ведіть ім'я динозавра:");
                Name = Console.ReadLine();
            }

            if (type == null)
            {
                Console.Write("Ведіть вид динозавра:");
                type = Console.ReadLine();
            }
            
        }

        public void MoveTypes()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            
            if (Move == null)
            {
                Console.Write("Якщо динозавр рухається напишіть (1), якщо лежить (2), якщо їсть (3), якщо п'є (4), якщо помер (5) :");
                Move = Console.ReadLine();
                switch (Move)
                {
                    case "1":
                        Move = " ганяє по воль'єру";
                        break;
                    case "2":
                        Move = " ловить кайфарики";
                        break;
                    case "3":
                        Move =  " набиває пузо";
                        break;
                    case "4":
                        Move =  " заливається водою";
                        break;
                    case "5":
                        Move = " помер :(";
                        break;
                    default:
                        Console.WriteLine("Дію обрано не правильно");
                        break;

                }
            }
           
        }
        public void WriteInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
          
            Console.WriteLine("\t Інформація: ");

            Console.WriteLine($"{type}  {Name}  {Move} ");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
