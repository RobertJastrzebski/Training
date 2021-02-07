using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraWStatkiLibrary.Modele
{
    public class GraczInfo
    {
        public string ImieGracza { get; set; }
        public List<MiejsceNaSiatce> LokalizacjaStatków { get; set; }= new List<MiejsceNaSiatce>();

        public List<MiejsceNaSiatce> LokalizacjaStrzałów { get; set; }= new List<MiejsceNaSiatce>();
    }
}
