using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_1
{
    internal interface Dino
    {
        public string Type { get; set; }    
        public string Age { get; set; }
        public void ReadValues();
        public void MoveTypes ();
        public void WriteInfo();

        
    }
}
