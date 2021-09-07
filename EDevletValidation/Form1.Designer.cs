
namespace EDevletValidation
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dogum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Doğrula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C Kimlik Numarası:";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(168, 44);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(233, 22);
            this.tc.TabIndex = 2;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(168, 88);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(233, 22);
            this.ad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ADI:";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(168, 130);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(233, 22);
            this.soyad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SOYADI:";
            // 
            // dogum
            // 
            this.dogum.Location = new System.Drawing.Point(168, 173);
            this.dogum.Name = "dogum";
            this.dogum.Size = new System.Drawing.Size(233, 22);
            this.dogum.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doğum Yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Devlet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dogum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dogum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

