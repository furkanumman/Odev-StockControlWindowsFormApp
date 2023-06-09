using Ders26.Models;
using Ders26.Services;

namespace Ders26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            foreach (Urun urun in AlisverisServisi.urunListesi)
            {
                ListViewItem listViewItem = new ListViewItem(urun.Id.ToString());
                listViewItem.SubItems.Add(urun.Ismi.ToString());
                listViewItem.SubItems.Add(urun.Fiyat.ToString());
                listViewItem.SubItems.Add(urun.Adet.ToString());

                listView1.Items.Add(listViewItem);
            }
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = 0;
                var selectedItem = listView1.SelectedItems[0];
                int selectedItemIndex = listView1.Items.IndexOf(selectedItem);
                id = Convert.ToInt32(selectedItem.Text);

                Urun guncellenmisUrun = AlisverisServisi.UrunEkle(id, Convert.ToInt32(numericUpDown1.Value));

                ListViewItem listViewItem = new ListViewItem(guncellenmisUrun.Id.ToString());
                listViewItem.SubItems.Add(guncellenmisUrun.Ismi.ToString());
                listViewItem.SubItems.Add(guncellenmisUrun.Fiyat.ToString());
                listViewItem.SubItems.Add(guncellenmisUrun.Adet.ToString());

                listView1.Items.Remove(selectedItem);
                listView1.Items.Insert(selectedItemIndex, listViewItem);
                numericUpDown1.Value = 0;
            }
            else
            {
                FormVeriEkleme formVeriEkleme = new FormVeriEkleme(listView1);
                formVeriEkleme.ShowDialog();
                numericUpDown1.Value = 0;

                //MessageBox.Show("Herhangi bir ürün seçmediniz!");
            }
        }

        private void urunCikartButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = 0;
                var selectedItem = listView1.SelectedItems[0];
                int selectedItemIndex = listView1.Items.IndexOf(selectedItem);
                id = Convert.ToInt32(selectedItem.Text);
                bool basariliMi = true;
                Urun guncellenmisUrun = AlisverisServisi.UrunCikart(id, Convert.ToInt32(numericUpDown1.Value), ref basariliMi);

                if (!basariliMi)
                {
                    return;
                }
                ListViewItem listViewItem = new ListViewItem(guncellenmisUrun.Id.ToString());
                listViewItem.SubItems.Add(guncellenmisUrun.Ismi.ToString());
                listViewItem.SubItems.Add(guncellenmisUrun.Fiyat.ToString());
                listViewItem.SubItems.Add(guncellenmisUrun.Adet.ToString());

                listView1.Items.Remove(selectedItem);
                listView1.Items.Insert(selectedItemIndex, listViewItem);
                numericUpDown1.Value = 0;
            }
            else
            {
                MessageBox.Show("Herhangi bir ürün seçmediniz!");
            }
        }
    }
}