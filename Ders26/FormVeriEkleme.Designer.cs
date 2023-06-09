namespace Ders26
{
    partial class FormVeriEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nuAdet = new NumericUpDown();
            txtID = new TextBox();
            txtUrunIsmi = new TextBox();
            cmbUrunTipi = new ComboBox();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)nuAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 15);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 0;
            label2.Text = "Ürün İsmi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 85);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 0;
            label3.Text = "Adet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 157);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 0;
            label4.Text = "Ürün Tipi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 122);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 0;
            label5.Text = "Fiyat:";
            // 
            // nuAdet
            // 
            nuAdet.Location = new Point(99, 83);
            nuAdet.Margin = new Padding(4);
            nuAdet.Name = "nuAdet";
            nuAdet.Size = new Size(124, 29);
            nuAdet.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(99, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(124, 29);
            txtID.TabIndex = 2;
            // 
            // txtUrunIsmi
            // 
            txtUrunIsmi.Location = new Point(99, 47);
            txtUrunIsmi.Name = "txtUrunIsmi";
            txtUrunIsmi.Size = new Size(124, 29);
            txtUrunIsmi.TabIndex = 2;
            // 
            // cmbUrunTipi
            // 
            cmbUrunTipi.FormattingEnabled = true;
            cmbUrunTipi.Location = new Point(99, 154);
            cmbUrunTipi.Name = "cmbUrunTipi";
            cmbUrunTipi.Size = new Size(124, 29);
            cmbUrunTipi.TabIndex = 3;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(99, 119);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(124, 29);
            txtFiyat.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(102, 201);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(121, 49);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FormVeriEkleme
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 294);
            Controls.Add(btnKaydet);
            Controls.Add(cmbUrunTipi);
            Controls.Add(txtFiyat);
            Controls.Add(txtUrunIsmi);
            Controls.Add(txtID);
            Controls.Add(nuAdet);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormVeriEkleme";
            Text = "FormVeriEkleme";
            Load += FormVeriEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)nuAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nuAdet;
        private TextBox txtID;
        private TextBox txtUrunIsmi;
        private ComboBox cmbUrunTipi;
        private TextBox txtFiyat;
        private Button btnKaydet;
    }
}