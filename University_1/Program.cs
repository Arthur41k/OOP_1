namespace Food
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Створення об'єкту класу McDonalds
            var McDonalds_1 = new McDonalds("Вулиця Березняківська 2Б");
            //Використання методів класу McDonalds та батьківського класу FastFood
            string order = McDonalds_1.Menu();
            McDonalds_1.Issuance(order);
            Console.WriteLine("Напишіть вашу адресу:");
            McDonalds_1.Delivery(order);
           
            //Створення об'єкту класу KFC
            var KFC_1 = new KFC("Хрещатик");           
            //Використання методів класу KFC та батьківського класу FastFood
            string order_2 = KFC_1.Menu();
            KFC_1.Issuance(order_2);
            KFC_1.Party(02,06,8);
        }
    }
}
