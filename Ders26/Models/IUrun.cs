using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26.Models
{
    public interface IUrun
    {
        public int Id { get; set; }
        public string Ismi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public UrunTipi Tip { get; }
    }
}
