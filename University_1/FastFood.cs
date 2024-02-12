using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1
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
        public string Order_Acceptance()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Меню:\n Бургер (1) \n Картопля Фрі (2)\n Напій (3) \n Комплект(4)");
            string acceptance = Console.ReadLine();
            string order;
            switch (acceptance)
            {
                case "1" : order = "Бургер";
                    break;
                case "2":  order = "Картопля фрі";
                    break;
                case "3": order = "Напій";
                    break;
                case "4": order = "Бургер, картопля фрі та напій";
                    break;
                default:
                    order ="З меню нічого не обрано";
                    break;
            }
            return order;
            Console.ResetColor();
        }

        /// <summary>
        /// Метод Issuance приймає замовлення обробляє його та готує.
        /// </summary>
        /// <param name="order"></param>
        public void Issuance(string order) 
        {
            Console.WriteLine("Зачекайте");
            Thread.Sleep(3000);
            Random N = new Random();
            int Number = N.Next(1, 100);
            Console.WriteLine( $"Замовлення номер {Number}: \n {order} \n Виконано");
        }
    }
}
