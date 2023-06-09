using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26.Models
{
    public abstract class Urun : IUrun
    {
        public string Ismi { get; set; }
        public int Adet { get ; set ; }
        public decimal Fiyat { get ; set ; }
        public abstract UrunTipi Tip { get; }
        public int Id { get ; set ; }
        //public UrunTipi Tip { get { return UrunTipi.Giyim; } }

        //public UrunTipi Tip => UrunTipi.Gıda;
    }
}
