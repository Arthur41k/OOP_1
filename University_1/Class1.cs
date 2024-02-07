using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace University_1
{
    /// <summary>
    /// Клас LandDinosaurus включає методи для опису і видачі інформації про сухопутного динозавра
    /// </summary>
    class LandDinosaurus:IDino
    {
        public int number_1;
        public LandDinosaurus(int number) 
        {
            this.number_1 = number;
        }
        string Name;
        string type;
        string Move;
     
        /// <summary>
        /// Збір інформації про ім'я та вид динозавра
        /// </summary>
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

        /// <summary>
        /// Збір інформації про дію або стан динозавра
        /// </summary>
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
        /// <summary>
        /// Вивід існуючої інформації про динозавра 
        /// </summary>
        public void WriteInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
          
            Console.WriteLine("\t Інформація номер " + number_1);

            Console.WriteLine($"  {type}  {Name}  {Move} ");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
