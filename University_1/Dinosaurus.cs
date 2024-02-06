using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1
{
    public interface Dinosaurus
    {     
        string Name { get; }        
        string type {  get; }
        string Move {  get; }

        void Names (string Name)
        {
            if (Name == null)
            {

                Console.WriteLine("Динозавр");
            }
            else
            {
                Console.WriteLine(Name);
            }
        }
        void Types (string type)
        {
            if (type == null)
            {
                Console.WriteLine("Вимерший");
            }
            else
            {
                Console.WriteLine(type);
            }   
        }

        void Moves (string move)
        {
            if (move == null)
            {
                Console.WriteLine("Рухатись");
            }
            else 
            {
                Console.WriteLine(move); 
            }

        }

    }
}
