using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphaneClass.Masa_yönetim
{
    public class Masa
    {
        
        public int No { get; set; }
        public bool DoluMu { get; set; }

        public Masa(int no, bool durum)
        {
            No = no;
            DoluMu = durum;
        }
    }
}
