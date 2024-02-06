namespace University_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Напишіть про свого динозавра");
            var Raptor = new LandDinosaurus();
            Raptor.ReadValues();
            Raptor.MoveTypes();
            Raptor.WriteInfo();
        }
    }
}
