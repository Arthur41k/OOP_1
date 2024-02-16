using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            string adress = Console.ReadLine();
            int Time = N.Next(20, 35);
            Console.WriteLine($"Доставка замовлення буде здійснена з {McAddress} в {adress} приблизно через {Time} хвилин. \n Замовлення: {order}");
            Thread.Sleep( Time * 100 );
            Console.WriteLine("Замовлення доставлено");
            Console.ResetColor();
        }

        //Добавлення до батьківського методу елементи з меню McDonalds
        public override string Menu()
        {
            
            string KFC_Order = base.Menu();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Меню McDonalds:\n Бігмак меню (4) \n Даблчізбургер меню (5) \n Чікенрол (6) ");
            string acceptance = Console.ReadLine();
            string order;
            if (acceptance == "4")
            {
                order = "Бігмак, картопля фрі, напій";

            }
            else if (acceptance == "5")
            {
                order = "Даблчізбургер, картопля фрі, напій";

            }
            else
            {
                order = "Чікенрол";

            }
            Console.ResetColor();
            return $"{KFC_Order} \n {order}";
        }
    }
}
   

