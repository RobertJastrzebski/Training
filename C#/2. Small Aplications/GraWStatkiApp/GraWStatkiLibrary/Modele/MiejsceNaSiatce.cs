using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWStatkiLibrary.Modele
{
    public class MiejsceNaSiatce
    {
        public string MiejsceLitera { get; set; }
        public int MiejsceCyfra { get; set; }


        public StatusPola Status { get; set; } = StatusPola.puste; 
        
    }
}
