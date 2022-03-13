
namespace WindowsFormsApp1
{
    partial class Giris
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
            this.kayitol = new System.Windows.Forms.Button();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.girisyap = new System.Windows.Forms.Button();
            this.sifreyazi = new System.Windows.Forms.Label();
            this.kullaniciaditextbox = new System.Windows.Forms.TextBox();
            this.kullaniciadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kapat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kayitol
            // 
            this.kayitol.BackColor = System.Drawing.SystemColors.Control;
            this.kayitol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kayitol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitol.Location = new System.Drawing.Point(38, 174);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(203, 25);
            this.kayitol.TabIndex = 14;
            this.kayitol.Text = "Kayıt Ol";
            this.kayitol.UseVisualStyleBackColor = false;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click);
            // 
            // sifretextbox
            // 
            this.sifretextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretextbox.Location = new System.Drawing.Point(111, 97);
            this.sifretextbox.MaxLength = 30;
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.Size = new System.Drawing.Size(156, 20);
            this.sifretextbox.TabIndex = 12;
            // 
            // girisyap
            // 
            this.girisyap.BackColor = System.Drawing.SystemColors.Control;
            this.girisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyap.Location = new System.Drawing.Point(38, 143);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(203, 25);
            this.girisyap.TabIndex = 13;
            this.girisyap.Text = "Giriş Yap";
            this.girisyap.UseVisualStyleBackColor = false;
            this.girisyap.Click += new System.EventHandler(this.girisyap_Click);
            // 
            // sifreyazi
            // 
            this.sifreyazi.AutoSize = true;
            this.sifreyazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreyazi.Location = new System.Drawing.Point(65, 97);
            this.sifreyazi.Name = "sifreyazi";
            this.sifreyazi.Size = new System.Drawing.Size(40, 16);
            this.sifreyazi.TabIndex = 11;
            this.sifreyazi.Text = "Şifre";
            // 
            // kullaniciaditextbox
            // 
            this.kullaniciaditextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kullaniciaditextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciaditextbox.Location = new System.Drawing.Point(111, 65);
            this.kullaniciaditextbox.MaxLength = 10;
            this.kullaniciaditextbox.Name = "kullaniciaditextbox";
            this.kullaniciaditextbox.Size = new System.Drawing.Size(156, 20);
            this.kullaniciaditextbox.TabIndex = 10;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSize = true;
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciadi.Location = new System.Drawing.Point(12, 66);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(93, 16);
            this.kullaniciadi.TabIndex = 9;
            this.kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "GİRİŞ";
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.SystemColors.Control;
            this.kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.Location = new System.Drawing.Point(38, 205);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(203, 25);
            this.kapat.TabIndex = 17;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(286, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.girisyap);
            this.Controls.Add(this.sifreyazi);
            this.Controls.Add(this.kullaniciaditextbox);
            this.Controls.Add(this.kullaniciadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayitol;
        private System.Windows.Forms.TextBox sifretextbox;
        private System.Windows.Forms.Button girisyap;
        private System.Windows.Forms.Label sifreyazi;
        private System.Windows.Forms.TextBox kullaniciaditextbox;
        private System.Windows.Forms.Label kullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label2;
    }
}

