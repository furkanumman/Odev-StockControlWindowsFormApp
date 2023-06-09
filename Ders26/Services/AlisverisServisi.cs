using Ders26.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26.Services
{
    public static class AlisverisServisi
    {
        public static List<Urun> urunListesi = new List<Urun>();

        static AlisverisServisi()
        {
            Urun urun1 = new Gida() { Adet = 30, Ismi = "Bebe Bisküvisi", Fiyat = 20, Id = 1 };
            Urun urun2 = new Gida() { Adet = 3, Ismi = "Elma", Fiyat = 300, Id = 2 };
            Urun urun3 = new Gida() { Adet = 0, Ismi = "Çilek", Fiyat = 21, Id = 3 };
            Urun urun4 = new Gida() { Adet = 0, Ismi = "Ekmek", Fiyat = 76, Id = 4 };
            Urun urun5 = new Hijyen() { Adet = 0, Ismi = "Domestos", Fiyat = 576, Id = 5 };
            Urun urun6 = new Kirtasiye() { Adet = 7, Ismi = "Defter", Fiyat = 200, Id = 6 };
            Urun urun7 = new Teknoloji() { Adet = 4, Ismi = "Telefon", Fiyat = 3000, Id = 7 };

            urunListesi.Add(urun1);
            urunListesi.Add(urun2);
            urunListesi.Add(urun3);
            urunListesi.Add(urun4);
            urunListesi.Add(urun5);
            urunListesi.Add(urun6);
            urunListesi.Add(urun7);
        }

        public static Urun UrunEkle(int urunId, int adet)
        {
            Urun secilenUrun = urunListesi.FirstOrDefault(x => x.Id == urunId);
            secilenUrun.Adet = secilenUrun.Adet + adet;

            return secilenUrun;
        }

        public static Urun UrunCikart(int urunId, int adet, ref bool basariliMi)
        {
            Urun secilenUrun = urunListesi.FirstOrDefault(x => x.Id == urunId);

            if (secilenUrun.Adet < adet)
            {
                MessageBox.Show("Mevcut adetten fazla adet silmeye çalışıyorsunuz!");
                basariliMi = false;
                return secilenUrun;
            }
            else
            {
                secilenUrun.Adet = secilenUrun.Adet - adet;

                return secilenUrun;
            }
        }


        public static Urun YeniUrunEkleme(int urunID, string urunIsmi, int adet, int fiyat, int urunTipi, ref bool ekleyeyimMi)
        {
            //MessageBox.Show(urunTipi.ToString());
            bool elemaniMi = urunListesi.Exists((x => x.Id == urunID));

            UrunYonetimi urunYonetimi = new UrunYonetimi();
            Urun yeniUrun = urunYonetimi.TipOlusturucu(urunTipi, urunID, urunIsmi, adet, fiyat);

            if (elemaniMi)
            {
                MessageBox.Show("ID'si var olan elemanı eklemeye çalışıyorsunuz!");
                ekleyeyimMi = false;
                //urunListesi.Remove(yeniUrun);
                return yeniUrun;
            }
            else
            {
                urunListesi.Add(yeniUrun);
                ekleyeyimMi = true;
                return yeniUrun;
            }
        }


    }
}
