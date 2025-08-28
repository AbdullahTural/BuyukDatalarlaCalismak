namespace BuyukDatalarIleCalismak
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_resim_ekle = new System.Windows.Forms.Button();
            this.pic_resim = new System.Windows.Forms.PictureBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_kisi_listesi = new System.Windows.Forms.ComboBox();
            this.pic_dg_resim = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dg_isim = new System.Windows.Forms.TextBox();
            this.txt_dg_telefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dg_soyisim = new System.Windows.Forms.TextBox();
            this.txt_dg_Eposta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dg_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Kaydet);
            this.groupBox1.Controls.Add(this.btn_resim_ekle);
            this.groupBox1.Controls.Add(this.pic_resim);
            this.groupBox1.Controls.Add(this.txt_telefon);
            this.groupBox1.Controls.Add(this.txt_soyisim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Eposta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayit Ekle";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(53, 315);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(204, 23);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_resim_ekle
            // 
            this.btn_resim_ekle.Location = new System.Drawing.Point(379, 315);
            this.btn_resim_ekle.Name = "btn_resim_ekle";
            this.btn_resim_ekle.Size = new System.Drawing.Size(221, 23);
            this.btn_resim_ekle.TabIndex = 3;
            this.btn_resim_ekle.Text = "Resim Ekle";
            this.btn_resim_ekle.UseVisualStyleBackColor = true;
            this.btn_resim_ekle.Click += new System.EventHandler(this.btn_resim_ekle_Click);
            // 
            // pic_resim
            // 
            this.pic_resim.Location = new System.Drawing.Point(379, 98);
            this.pic_resim.Name = "pic_resim";
            this.pic_resim.Size = new System.Drawing.Size(221, 210);
            this.pic_resim.TabIndex = 2;
            this.pic_resim.TabStop = false;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(113, 182);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(144, 22);
            this.txt_telefon.TabIndex = 1;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(113, 126);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(144, 22);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(113, 154);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(144, 22);
            this.txt_Eposta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eposta";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(113, 98);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(144, 22);
            this.txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_kisi_listesi);
            this.groupBox2.Controls.Add(this.pic_dg_resim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_dg_isim);
            this.groupBox2.Controls.Add(this.txt_dg_telefon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_dg_soyisim);
            this.groupBox2.Controls.Add(this.txt_dg_Eposta);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(803, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 380);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayit Görüntüle";
            // 
            // cmb_kisi_listesi
            // 
            this.cmb_kisi_listesi.FormattingEnabled = true;
            this.cmb_kisi_listesi.Location = new System.Drawing.Point(69, 36);
            this.cmb_kisi_listesi.Name = "cmb_kisi_listesi";
            this.cmb_kisi_listesi.Size = new System.Drawing.Size(547, 24);
            this.cmb_kisi_listesi.TabIndex = 4;
            this.cmb_kisi_listesi.SelectedIndexChanged += new System.EventHandler(this.cmb_kisi_listesi_SelectedIndexChanged);
            // 
            // pic_dg_resim
            // 
            this.pic_dg_resim.Location = new System.Drawing.Point(394, 98);
            this.pic_dg_resim.Name = "pic_dg_resim";
            this.pic_dg_resim.Size = new System.Drawing.Size(222, 210);
            this.pic_dg_resim.TabIndex = 2;
            this.pic_dg_resim.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "İsim";
            // 
            // txt_dg_isim
            // 
            this.txt_dg_isim.Location = new System.Drawing.Point(129, 98);
            this.txt_dg_isim.Name = "txt_dg_isim";
            this.txt_dg_isim.Size = new System.Drawing.Size(144, 22);
            this.txt_dg_isim.TabIndex = 1;
            // 
            // txt_dg_telefon
            // 
            this.txt_dg_telefon.Location = new System.Drawing.Point(129, 182);
            this.txt_dg_telefon.Name = "txt_dg_telefon";
            this.txt_dg_telefon.Size = new System.Drawing.Size(144, 22);
            this.txt_dg_telefon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eposta";
            // 
            // txt_dg_soyisim
            // 
            this.txt_dg_soyisim.Location = new System.Drawing.Point(129, 126);
            this.txt_dg_soyisim.Name = "txt_dg_soyisim";
            this.txt_dg_soyisim.Size = new System.Drawing.Size(144, 22);
            this.txt_dg_soyisim.TabIndex = 1;
            // 
            // txt_dg_Eposta
            // 
            this.txt_dg_Eposta.Location = new System.Drawing.Point(129, 154);
            this.txt_dg_Eposta.Name = "txt_dg_Eposta";
            this.txt_dg_Eposta.Size = new System.Drawing.Size(144, 22);
            this.txt_dg_Eposta.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Soyisim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Büyük Datalar İle Çalışmak";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dg_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_resim_ekle;
        private System.Windows.Forms.PictureBox pic_resim;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_kisi_listesi;
        private System.Windows.Forms.PictureBox pic_dg_resim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dg_isim;
        private System.Windows.Forms.TextBox txt_dg_telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dg_soyisim;
        private System.Windows.Forms.TextBox txt_dg_Eposta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

