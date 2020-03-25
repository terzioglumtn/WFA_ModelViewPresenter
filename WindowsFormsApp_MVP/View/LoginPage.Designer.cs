namespace WindowsFormsApp_MVP
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
            this.label_kullaniciAdiText = new System.Windows.Forms.Label();
            this.label_sifreText = new System.Windows.Forms.Label();
            this.textBox_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.button_giris = new System.Windows.Forms.Button();
            this.label_girisDurumuText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_girisDurumuText);
            this.groupBox1.Controls.Add(this.button_giris);
            this.groupBox1.Controls.Add(this.textBox_sifre);
            this.groupBox1.Controls.Add(this.textBox_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label_sifreText);
            this.groupBox1.Controls.Add(this.label_kullaniciAdiText);
            this.groupBox1.Location = new System.Drawing.Point(42, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yapınız";
            // 
            // label_kullaniciAdiText
            // 
            this.label_kullaniciAdiText.AutoSize = true;
            this.label_kullaniciAdiText.Location = new System.Drawing.Point(115, 62);
            this.label_kullaniciAdiText.Name = "label_kullaniciAdiText";
            this.label_kullaniciAdiText.Size = new System.Drawing.Size(84, 17);
            this.label_kullaniciAdiText.TabIndex = 0;
            this.label_kullaniciAdiText.Text = "Kullanıcı Adı";
            // 
            // label_sifreText
            // 
            this.label_sifreText.AutoSize = true;
            this.label_sifreText.Location = new System.Drawing.Point(162, 107);
            this.label_sifreText.Name = "label_sifreText";
            this.label_sifreText.Size = new System.Drawing.Size(37, 17);
            this.label_sifreText.TabIndex = 1;
            this.label_sifreText.Text = "Şifre";
            // 
            // textBox_kullaniciAdi
            // 
            this.textBox_kullaniciAdi.Location = new System.Drawing.Point(232, 59);
            this.textBox_kullaniciAdi.Name = "textBox_kullaniciAdi";
            this.textBox_kullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.textBox_kullaniciAdi.TabIndex = 2;
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(232, 104);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(100, 22);
            this.textBox_sifre.TabIndex = 3;
            // 
            // button_giris
            // 
            this.button_giris.Location = new System.Drawing.Point(181, 170);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(94, 37);
            this.button_giris.TabIndex = 4;
            this.button_giris.Text = "GİRİŞ";
            this.button_giris.UseVisualStyleBackColor = true;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label_girisDurumuText
            // 
            this.label_girisDurumuText.AutoSize = true;
            this.label_girisDurumuText.Location = new System.Drawing.Point(205, 233);
            this.label_girisDurumuText.Name = "label_girisDurumuText";
            this.label_girisDurumuText.Size = new System.Drawing.Size(0, 17);
            this.label_girisDurumuText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LoginPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_sifreText;
        private System.Windows.Forms.Label label_kullaniciAdiText;
        private System.Windows.Forms.TextBox textBox_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Button button_giris;
        private System.Windows.Forms.Label label_girisDurumuText;
    }
}

