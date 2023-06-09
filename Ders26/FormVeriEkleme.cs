using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders26.Models;
using Ders26.Services;

namespace Ders26
{
    public partial class FormVeriEkleme : Form
    {
        ListView listViewEkle = new ListView();
        public FormVeriEkleme(ListView _listView)
        {
            InitializeComponent();
            listViewEkle = _listView;
        }

        private void FormVeriEkleme_Load(object sender, EventArgs e)
        {
            SetupUI();
        }

        void SetupUI()
        {
            cmbUrunTipi.Items.AddRange(Enum.GetNames(typeof(UrunTipi)));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool ekleyeyimMi = true;
            Urun yeniUrun = AlisverisServisi.YeniUrunEkleme(Convert.ToInt32(txtID.Text), txtUrunIsmi.Text, Convert.ToInt32(nuAdet.Value), Convert.ToInt32(txtFiyat.Text), cmbUrunTipi.SelectedIndex, ref ekleyeyimMi);

            if (ekleyeyimMi)
            {
                ListViewItem listViewItem = new ListViewItem(yeniUrun.Id.ToString());
                listViewItem.SubItems.Add(yeniUrun.Ismi.ToString());
                listViewItem.SubItems.Add(yeniUrun.Fiyat.ToString());
                listViewItem.SubItems.Add(yeniUrun.Adet.ToString());
                listViewEkle.Items.Add(listViewItem);
            }

        }


    }
}
