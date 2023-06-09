using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26.Models
{
    public sealed class Makyaj : Urun
    {
        public override UrunTipi Tip => UrunTipi.Makyaj;
    }
}
