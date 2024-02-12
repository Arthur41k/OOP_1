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
           
        }
    }
}
