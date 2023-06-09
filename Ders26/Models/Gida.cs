using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26.Models
{
    public sealed class Gida : Urun
    {
        public override UrunTipi Tip => UrunTipi.Gıda;
    }
}
