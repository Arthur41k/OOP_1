using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1
{
    /// <summary>
    /// Клас KFC наслідує FastFood та приймає адресу де знаходиться заклад і використовує методи для обробки замовлень.
    /// </summary>
    class KFC :FastFood
    {
        Random N = new Random();
        public string address;

        public KFC(string Address_1) 
        {
            this.address = Address_1;
        }

        /// <summary>
        /// Метод який приймає замовлення та кількість людей і бронює заклад для вечірки
        /// </summary>
        /// <param name="order"></param>
        /// <param name="Number"></param>
        public void Party(string order, int Number)
        {
            int day = N.Next(1,29);
            int month = N.Next(1,30);

            Console.WriteLine($"Вечірку заброньовано на {day}.{month} на {Number} людей за адресою {address} \n Меню: \n {order} у кількості {Number}порцій");
        }

        /// <summary>
        /// Видає замовлення для тих хто любить гостреньке
        /// </summary>
        /// <returns></returns>
        public string SpaicyBaсket()
        {
            return "Відерце з гострими курячими крилцями, Фанта 0,5 л";
        }

        /// <summary>
        /// Видає стандартне замовлення KFC для тих хто любить поласувати курочкою
        /// </summary>
        /// <returns></returns>
        public string StandartBacket()
        {
            return "Відерце з курячими ніжками";
        }
    }
}
