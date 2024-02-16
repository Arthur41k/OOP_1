using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    /// <summary>
    /// Клас FastFood описує властивості фастфудів
    /// </summary>
     public class FastFood
      
    {
        
        /// <summary>
        /// Метод збирає інформацію про замовлення користувача
        /// </summary>
        /// <returns></returns>
        public virtual string Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Меню:\n Бургер (1) \n Картопля Фрі (2)\n Напій (3)");
            string acceptance = Console.ReadLine();
            string order;
            switch (acceptance)
            {
                case "1": order = "Бургер";
                    break;
                case "2": order = "Картопля фрі";
                    break;
                case "3": order = "Напій";
                    break;                
                default:
                    order = "З меню нічого не обрано";
                    break;
            }
            Console.ResetColor();
            return order;
            
        }

        /// <summary>
        /// Метод Issuance приймає замовлення обробляє його та готує.
        /// </summary>
        /// <param name="order"></param>
        
        
       public void Issuance(string order)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random Name = new Random();
            int random = Name.Next(1, 6);
            if (random == 6)
            {
                Console.WriteLine("Почалась повітряна тревога.Чекайте відбою.");
                Thread.Sleep(10000);
                Console.WriteLine("Відбій повітряної тревоги.Зачекайте поки зроблять ваше замовлення.");
                Thread.Sleep(3000);
                Random N = new Random();
                int Number = N.Next(1, 100);
                Console.WriteLine($"Замовлення номер {Number}: \n {order} \n Виконано");
            }
            else
            {
                Console.WriteLine("Зачекайте поки зроблять ваше замовлення.");
                Thread.Sleep(3000);
                Random N = new Random();
                int Number = N.Next(1, 100);
                Console.WriteLine($"Замовлення номер {Number}: \n {order} \n Виконано");
            }
            Console.ResetColor();
        }
    
    
    
    }
}
