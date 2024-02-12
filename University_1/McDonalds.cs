using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1
{
    /// <summary>
    /// McDonalds є підкласом FastFood який приймає адресу де знаходиться заклад та використовує методи для обробки замовлень.
    /// </summary>
     class McDonalds:FastFood
    {
        Random N = new Random();
        public string McAddress;
        
        public McDonalds(string address) 
        {
            
             this.McAddress = address;
     
             
        }

        /// <summary>
        /// Приймає замовлення і виконує доставку
        /// </summary>
        /// <param name="order"></param>
        public void Delivery(string order)
        {
            string adress = Console.ReadLine();
            int Time = N.Next(20, 35);
            Console.WriteLine($"Доставка замовлення буде здійснена з {McAddress} в {adress} приблизно через {Time} хвилин. \n Замовлення: {order}");
        }

        /// <summary>
        /// Робить замовлення для сніданку
        /// </summary>
        /// <returns></returns>
        public string Breakfast()
        {
            return "ЧікенРол, кава та вишневий МакПеріг";
        }

        /// <summary>
        /// Робить замовлення для швидкого робочого перекусу
        /// </summary>
        /// <returns></returns>
        public string BiznesLunch()
        {
            return "Дабл чізбургер, нагетси 6 шт. , Кока-Кола 0,5 л";
        }
    }
   
}
