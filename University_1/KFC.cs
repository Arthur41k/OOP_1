using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food

{
    /// <summary>
    /// Клас KFC наслідує FastFood та приймає адресу де знаходиться заклад і використовує методи для обробки замовлень.
    /// </summary>
    class KFC : FastFood
    {
        Random N = new Random();
        public string Address;

        public KFC(string address)
        {
            this.Address = address;
        }

        /// <summary>
        /// Метод який приймає  кількість людей і бронює на обраний день заклад для вечірки
        /// </summary>
        /// <param name="order"></param>
        /// <param name="Number"></param>
        public void Party(int day, int month, int Number)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Вечірку заброньовано на {day}.{month} на {Number} людей за адресою {Address}.");
            Console.ResetColor();
        }

        //Добавлення до батьківського методу елементи з меню KFC
        public override string Menu()
        {
            
            string KFC_Order = base.Menu();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Меню KFC:\n Відерце з 6-тьма  курячими крилцями (4) \n Відерце з 6-тьма ГОСТРИМИ курячими крилцями (5)\n Відерце з 5-тьма курячими ніжками (6) ");
            string acceptance = Console.ReadLine();
            string order;
            if (acceptance == "4")
            {
                order = "Відерце з  курячими крилцями";
                
            }
            else if (acceptance == "5") 
            {
                order = "Відерце з гострими курячими крилцями";
                
            }
            else 
            {
                order = "Відерце з курячими ніжками";
                
            }
            Console.ResetColor();
            return $"{KFC_Order} \n {order}";
        }
            
    }
}
