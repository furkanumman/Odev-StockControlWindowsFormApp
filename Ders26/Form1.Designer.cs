namespace Ders26
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            urunEkleButton = new Button();
            numericUpDown1 = new NumericUpDown();
            urunCikartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürünler";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(21, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(400, 300);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Fiyatı";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adet";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // urunEkleButton
            // 
            urunEkleButton.Location = new Point(434, 111);
            urunEkleButton.Name = "urunEkleButton";
            urunEkleButton.Size = new Size(87, 36);
            urunEkleButton.TabIndex = 2;
            urunEkleButton.Text = "Ürün Ekle";
            urunEkleButton.UseVisualStyleBackColor = true;
            urunEkleButton.Click += urunEkleButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(434, 56);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // urunCikartButton
            // 
            urunCikartButton.Location = new Point(548, 111);
            urunCikartButton.Name = "urunCikartButton";
            urunCikartButton.Size = new Size(87, 36);
            urunCikartButton.TabIndex = 4;
            urunCikartButton.Text = "Ürün Çıkart";
            urunCikartButton.UseVisualStyleBackColor = true;
            urunCikartButton.Click += urunCikartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 366);
            Controls.Add(urunCikartButton);
            Controls.Add(numericUpDown1);
            Controls.Add(urunEkleButton);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button urunEkleButton;
        private ColumnHeader columnHeader4;
        private NumericUpDown numericUpDown1;
        private Button urunCikartButton;
    }
}