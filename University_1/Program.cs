namespace University_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Напишіть про свого динозавра");
            //Створення об'єкту класу LandDinosaurus
            var Raptor = new LandDinosaurus(1);
            //Використання методів класу LandDinosaurus
            Raptor.ReadValues();
            Raptor.MoveTypes();
            Raptor.WriteInfo();

            //Створення об'єкту класу McDonalds
            var McDonalds_1 = new McDonalds("Вулиця Березняківська 2Б");
            //Використання методів класу McDonalds та батьківського класу FastFood
            string order = McDonalds_1.Breakfast();
            McDonalds_1.Issuance(order);
            Console.WriteLine("Напишіть вашу адресу:");
            McDonalds_1.Delivery(order);
           
            //Створення об'єкту класу KFC
            var KFC_1 = new KFC("Хрещатик");
            //Використання методів класу KFC та батьківського класу FastFood
            string order_2 = KFC_1.SpaicyBaсket();
            KFC_1.Issuance(order_2);
            KFC_1.Party(order_2,6);
        }
    }
}
