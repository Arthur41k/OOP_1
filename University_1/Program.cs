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
        }
    }
}
