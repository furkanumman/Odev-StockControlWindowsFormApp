using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ders26.Models
{
    public class UrunYonetimi
    {


        public Urun TipOlusturucu(int urunTipi, int urunID, string urunIsmi, int adet, int fiyat)
        {

            switch (urunTipi)
            {
                case (int)UrunTipi.Giyim:
                    return new Giyim() { Id = urunID, Ismi = urunIsmi, Adet = adet, Fiyat = fiyat };

                case (int)UrunTipi.Gıda:
                    return new Gida() { Id = urunID, Ismi = urunIsmi, Adet = adet, Fiyat = fiyat };

                case (int)UrunTipi.Hijyen:
                    return new Hijyen() { Id = urunID, Ismi = urunIsmi, Adet = adet, Fiyat = fiyat };

                case (int)UrunTipi.Kırtasiye:
                    return new Kirtasiye() { Id = urunID, Ismi = urunIsmi, Adet = adet, Fiyat = fiyat };

                case (int)UrunTipi.Makyaj:
                    return new Makyaj() { Id = urunID, Ismi = urunIsmi, Adet = adet, Fiyat = fiyat };

                case (int)UrunTipi.Teknoloji:
                    return new Teknoloji() { Id = urunID, Ismi = urunIsmi, Adet = adet, Fiyat = fiyat };

                default:
                    MessageBox.Show("Yanlış ürün tipi seçtiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;

            }

            return new Giyim();
        }

    }
}
