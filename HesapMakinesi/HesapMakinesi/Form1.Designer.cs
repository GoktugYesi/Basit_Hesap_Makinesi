
namespace HesapMakinesi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSıfır = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(0, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 31);
            this.textBox1.TabIndex = 50;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(104, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // btnSıfır
            // 
            this.btnSıfır.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSıfır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfır.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfır.Location = new System.Drawing.Point(104, 365);
            this.btnSıfır.Name = "btnSıfır";
            this.btnSıfır.Size = new System.Drawing.Size(86, 81);
            this.btnSıfır.TabIndex = 1;
            this.btnSıfır.Text = "0";
            this.btnSıfır.UseVisualStyleBackColor = false;
            this.btnSıfır.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfırla.Location = new System.Drawing.Point(196, 365);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(86, 81);
            this.btnSıfırla.TabIndex = 0;
            this.btnSıfırla.Text = "C";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // btnSonuc
            // 
            this.btnSonuc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSonuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonuc.Location = new System.Drawing.Point(12, 365);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(86, 81);
            this.btnSonuc.TabIndex = 1;
            this.btnSonuc.Tag = "topla";
            this.btnSonuc.Text = "=";
            this.btnSonuc.UseVisualStyleBackColor = false;
            this.btnSonuc.Click += new System.EventHandler(this.btnSıfırla_Click_1);
            // 
            // btnBir
            // 
            this.btnBir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBir.Location = new System.Drawing.Point(12, 278);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(86, 81);
            this.btnBir.TabIndex = 1;
            this.btnBir.Text = "1";
            this.btnBir.UseVisualStyleBackColor = false;
            this.btnBir.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(12, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 81);
            this.button6.TabIndex = 1;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(104, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 81);
            this.button7.TabIndex = 1;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(196, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 81);
            this.button8.TabIndex = 1;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(196, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 81);
            this.button9.TabIndex = 1;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(12, 104);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 81);
            this.button10.TabIndex = 1;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(104, 104);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(86, 81);
            this.button11.TabIndex = 1;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(196, 104);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 81);
            this.button12.TabIndex = 1;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnSıfır_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBol.Location = new System.Drawing.Point(288, 104);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(86, 81);
            this.btnBol.TabIndex = 1;
            this.btnBol.Tag = "bol";
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.Location = new System.Drawing.Point(288, 191);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(86, 81);
            this.btnCarp.TabIndex = 1;
            this.btnCarp.Tag = "carp";
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(288, 365);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(86, 81);
            this.btnTopla.TabIndex = 1;
            this.btnTopla.Tag = "topla";
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCıkar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkar.Location = new System.Drawing.Point(288, 278);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(86, 81);
            this.btnCıkar.TabIndex = 1;
            this.btnCıkar.Tag = "cikar";
            this.btnCıkar.Text = "-";
            this.btnCıkar.UseVisualStyleBackColor = false;
            this.btnCıkar.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 67);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(381, 458);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnBir);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnSıfır);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Göktuğ Bekir Yeşil Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSıfır;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Panel panel1;
    }
}

