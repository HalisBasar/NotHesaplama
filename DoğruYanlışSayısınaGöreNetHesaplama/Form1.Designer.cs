namespace DoğruYanlışSayısınaGöreNetHesaplama
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
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtTrhDogru = new System.Windows.Forms.TextBox();
            this.txtTrhYanlis = new System.Windows.Forms.TextBox();
            this.txtTrhNet = new System.Windows.Forms.TextBox();
            this.txtFizDogru = new System.Windows.Forms.TextBox();
            this.txtFizYanlis = new System.Windows.Forms.TextBox();
            this.txtFizNet = new System.Windows.Forms.TextBox();
            this.lblTürkce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btntemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(223, 67);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(100, 23);
            this.txtTurkceDogru.TabIndex = 0;
            this.txtTurkceDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTurkceDogru_KeyPress);
            // 
            // txtTurkceYanlis
            // 
            this.txtTurkceYanlis.Location = new System.Drawing.Point(366, 67);
            this.txtTurkceYanlis.Name = "txtTurkceYanlis";
            this.txtTurkceYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtTurkceYanlis.TabIndex = 1;
            this.txtTurkceYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTurkceYanlis_KeyPress);
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Enabled = false;
            this.txtTurkceNet.Location = new System.Drawing.Point(498, 67);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.Size = new System.Drawing.Size(100, 23);
            this.txtTurkceNet.TabIndex = 2;
            // 
            // txtTrhDogru
            // 
            this.txtTrhDogru.Location = new System.Drawing.Point(223, 113);
            this.txtTrhDogru.Name = "txtTrhDogru";
            this.txtTrhDogru.Size = new System.Drawing.Size(100, 23);
            this.txtTrhDogru.TabIndex = 3;
            this.txtTrhDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrhDogru_KeyPress);
            // 
            // txtTrhYanlis
            // 
            this.txtTrhYanlis.Location = new System.Drawing.Point(366, 113);
            this.txtTrhYanlis.Name = "txtTrhYanlis";
            this.txtTrhYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtTrhYanlis.TabIndex = 4;
            this.txtTrhYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrhYanlis_KeyPress);
            // 
            // txtTrhNet
            // 
            this.txtTrhNet.Enabled = false;
            this.txtTrhNet.Location = new System.Drawing.Point(498, 113);
            this.txtTrhNet.Name = "txtTrhNet";
            this.txtTrhNet.Size = new System.Drawing.Size(100, 23);
            this.txtTrhNet.TabIndex = 5;
            // 
            // txtFizDogru
            // 
            this.txtFizDogru.Location = new System.Drawing.Point(223, 160);
            this.txtFizDogru.Name = "txtFizDogru";
            this.txtFizDogru.Size = new System.Drawing.Size(100, 23);
            this.txtFizDogru.TabIndex = 6;
            this.txtFizDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFizDogru_KeyPress);
            // 
            // txtFizYanlis
            // 
            this.txtFizYanlis.Location = new System.Drawing.Point(366, 160);
            this.txtFizYanlis.Name = "txtFizYanlis";
            this.txtFizYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtFizYanlis.TabIndex = 7;
            this.txtFizYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFizYanlis_KeyPress);
            // 
            // txtFizNet
            // 
            this.txtFizNet.Enabled = false;
            this.txtFizNet.Location = new System.Drawing.Point(498, 160);
            this.txtFizNet.Name = "txtFizNet";
            this.txtFizNet.Size = new System.Drawing.Size(100, 23);
            this.txtFizNet.TabIndex = 8;
            // 
            // lblTürkce
            // 
            this.lblTürkce.AutoSize = true;
            this.lblTürkce.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTürkce.Location = new System.Drawing.Point(161, 66);
            this.lblTürkce.Name = "lblTürkce";
            this.lblTürkce.Size = new System.Drawing.Size(55, 20);
            this.lblTürkce.TabIndex = 9;
            this.lblTürkce.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fizik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(406, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(538, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Net";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHesapla.Location = new System.Drawing.Point(176, 231);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(215, 47);
            this.BtnHesapla.TabIndex = 15;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(538, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Net";
            // 
            // Btntemizle
            // 
            this.Btntemizle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btntemizle.Location = new System.Drawing.Point(431, 231);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(215, 47);
            this.Btntemizle.TabIndex = 16;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.UseVisualStyleBackColor = true;
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKapat.Location = new System.Drawing.Point(279, 326);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(215, 47);
            this.btnKapat.TabIndex = 17;
            this.btnKapat.Text = "Programı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.Btntemizle);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTürkce);
            this.Controls.Add(this.txtFizNet);
            this.Controls.Add(this.txtFizYanlis);
            this.Controls.Add(this.txtFizDogru);
            this.Controls.Add(this.txtTrhNet);
            this.Controls.Add(this.txtTrhYanlis);
            this.Controls.Add(this.txtTrhDogru);
            this.Controls.Add(this.txtTurkceNet);
            this.Controls.Add(this.txtTurkceYanlis);
            this.Controls.Add(this.txtTurkceDogru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.TextBox txtTurkceYanlis;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.TextBox txtTrhDogru;
        private System.Windows.Forms.TextBox txtTrhYanlis;
        private System.Windows.Forms.TextBox txtTrhNet;
        private System.Windows.Forms.TextBox txtFizDogru;
        private System.Windows.Forms.TextBox txtFizYanlis;
        private System.Windows.Forms.TextBox txtFizNet;
        private System.Windows.Forms.Label lblTürkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btntemizle;
        private System.Windows.Forms.Button btnKapat;
    }
}
