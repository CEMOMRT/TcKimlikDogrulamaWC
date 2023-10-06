
namespace TcKimlikDogrulamaWC
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTc = new System.Windows.Forms.TextBox();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.txbDogumYili = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTc
            // 
            this.txbTc.Location = new System.Drawing.Point(153, 58);
            this.txbTc.MaxLength = 11;
            this.txbTc.Name = "txbTc";
            this.txbTc.Size = new System.Drawing.Size(216, 22);
            this.txbTc.TabIndex = 0;
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(153, 107);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(216, 22);
            this.txbAd.TabIndex = 1;
            // 
            // txbSoyad
            // 
            this.txbSoyad.Location = new System.Drawing.Point(153, 164);
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(216, 22);
            this.txbSoyad.TabIndex = 2;
            // 
            // txbDogumYili
            // 
            this.txbDogumYili.Location = new System.Drawing.Point(153, 228);
            this.txbDogumYili.MaxLength = 4;
            this.txbDogumYili.Name = "txbDogumYili";
            this.txbDogumYili.Size = new System.Drawing.Size(216, 22);
            this.txbDogumYili.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Doğum yılı";
            // 
            // btnDogrula
            // 
            this.btnDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogrula.Location = new System.Drawing.Point(256, 296);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(223, 64);
            this.btnDogrula.TabIndex = 4;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 407);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDogumYili);
            this.Controls.Add(this.txbSoyad);
            this.Controls.Add(this.txbAd);
            this.Controls.Add(this.txbTc);
            this.Name = "Form1";
            this.Text = "TC Kimlik Doğrulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTc;
        private System.Windows.Forms.TextBox txbAd;
        private System.Windows.Forms.TextBox txbSoyad;
        private System.Windows.Forms.TextBox txbDogumYili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDogrula;
    }
}

