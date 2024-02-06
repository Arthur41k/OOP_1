using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1
{
    internal class Dino : IDino
    {
        string name;
        string types;
        string move;

        public void ReadValues()
        {
            this.name = Console.ReadLine();
            this.types = Console.ReadLine();
            
        }
        
        public void MoveTypes() 
        {
            this.move = Console.ReadLine();
        }
        public void WriteInfo()
        {
            Console.WriteLine($"{name} {types} {move}"  );
        }

       
    }
}
