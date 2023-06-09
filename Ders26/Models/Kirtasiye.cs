using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26.Models
{
    public sealed class Kirtasiye : Urun
    {
        public override UrunTipi Tip => UrunTipi.Kırtasiye;
    }
}
