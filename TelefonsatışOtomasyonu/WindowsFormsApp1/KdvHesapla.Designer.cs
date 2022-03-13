
namespace WindowsFormsApp1
{
    partial class KdvHesapla
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
            this.hesapla = new System.Windows.Forms.Button();
            this.kdvdahiltutaribox = new System.Windows.Forms.TextBox();
            this.kdvdahiltutarı = new System.Windows.Forms.Label();
            this.kdvtutaribox = new System.Windows.Forms.TextBox();
            this.kdvtutarılabel = new System.Windows.Forms.Label();
            this.yuzdesekiz = new System.Windows.Forms.RadioButton();
            this.yuzdeonsekiz = new System.Windows.Forms.RadioButton();
            this.kdvlabel = new System.Windows.Forms.Label();
            this.yuzdebir = new System.Windows.Forms.RadioButton();
            this.adetbox = new System.Windows.Forms.TextBox();
            this.adetlabel = new System.Windows.Forms.Label();
            this.tutarbox = new System.Windows.Forms.TextBox();
            this.tutarlabel = new System.Windows.Forms.Label();
            this.kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.BackColor = System.Drawing.SystemColors.Control;
            this.hesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(131, 119);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(120, 24);
            this.hesapla.TabIndex = 43;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // kdvdahiltutaribox
            // 
            this.kdvdahiltutaribox.Location = new System.Drawing.Point(131, 187);
            this.kdvdahiltutaribox.Name = "kdvdahiltutaribox";
            this.kdvdahiltutaribox.Size = new System.Drawing.Size(120, 20);
            this.kdvdahiltutaribox.TabIndex = 42;
            // 
            // kdvdahiltutarı
            // 
            this.kdvdahiltutarı.AutoSize = true;
            this.kdvdahiltutarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvdahiltutarı.Location = new System.Drawing.Point(12, 188);
            this.kdvdahiltutarı.Name = "kdvdahiltutarı";
            this.kdvdahiltutarı.Size = new System.Drawing.Size(113, 15);
            this.kdvdahiltutarı.TabIndex = 41;
            this.kdvdahiltutarı.Text = "KDV Dahil Tutarı";
            // 
            // kdvtutaribox
            // 
            this.kdvtutaribox.Location = new System.Drawing.Point(131, 161);
            this.kdvtutaribox.Name = "kdvtutaribox";
            this.kdvtutaribox.Size = new System.Drawing.Size(120, 20);
            this.kdvtutaribox.TabIndex = 40;
            // 
            // kdvtutarılabel
            // 
            this.kdvtutarılabel.AutoSize = true;
            this.kdvtutarılabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvtutarılabel.Location = new System.Drawing.Point(41, 162);
            this.kdvtutarılabel.Name = "kdvtutarılabel";
            this.kdvtutarılabel.Size = new System.Drawing.Size(79, 15);
            this.kdvtutarılabel.TabIndex = 39;
            this.kdvtutarılabel.Text = " KDV Tutarı";
            // 
            // yuzdesekiz
            // 
            this.yuzdesekiz.AutoSize = true;
            this.yuzdesekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuzdesekiz.Location = new System.Drawing.Point(156, 94);
            this.yuzdesekiz.Name = "yuzdesekiz";
            this.yuzdesekiz.Size = new System.Drawing.Size(41, 17);
            this.yuzdesekiz.TabIndex = 38;
            this.yuzdesekiz.TabStop = true;
            this.yuzdesekiz.Text = "%8";
            this.yuzdesekiz.UseVisualStyleBackColor = true;
            // 
            // yuzdeonsekiz
            // 
            this.yuzdeonsekiz.AutoSize = true;
            this.yuzdeonsekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuzdeonsekiz.Location = new System.Drawing.Point(203, 94);
            this.yuzdeonsekiz.Name = "yuzdeonsekiz";
            this.yuzdeonsekiz.Size = new System.Drawing.Size(48, 17);
            this.yuzdeonsekiz.TabIndex = 37;
            this.yuzdeonsekiz.TabStop = true;
            this.yuzdeonsekiz.Text = "%18";
            this.yuzdeonsekiz.UseVisualStyleBackColor = true;
            // 
            // kdvlabel
            // 
            this.kdvlabel.AutoSize = true;
            this.kdvlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvlabel.Location = new System.Drawing.Point(21, 95);
            this.kdvlabel.Name = "kdvlabel";
            this.kdvlabel.Size = new System.Drawing.Size(73, 15);
            this.kdvlabel.TabIndex = 36;
            this.kdvlabel.Text = "KDV Oranı";
            // 
            // yuzdebir
            // 
            this.yuzdebir.AutoSize = true;
            this.yuzdebir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuzdebir.Location = new System.Drawing.Point(109, 94);
            this.yuzdebir.Name = "yuzdebir";
            this.yuzdebir.Size = new System.Drawing.Size(41, 17);
            this.yuzdebir.TabIndex = 35;
            this.yuzdebir.TabStop = true;
            this.yuzdebir.Text = "%1";
            this.yuzdebir.UseVisualStyleBackColor = true;
            // 
            // adetbox
            // 
            this.adetbox.Location = new System.Drawing.Point(131, 61);
            this.adetbox.Name = "adetbox";
            this.adetbox.Size = new System.Drawing.Size(120, 20);
            this.adetbox.TabIndex = 34;
            // 
            // adetlabel
            // 
            this.adetlabel.AutoSize = true;
            this.adetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adetlabel.Location = new System.Drawing.Point(70, 61);
            this.adetlabel.Name = "adetlabel";
            this.adetlabel.Size = new System.Drawing.Size(35, 15);
            this.adetlabel.TabIndex = 33;
            this.adetlabel.Text = "Adet";
            // 
            // tutarbox
            // 
            this.tutarbox.Location = new System.Drawing.Point(131, 25);
            this.tutarbox.Name = "tutarbox";
            this.tutarbox.Size = new System.Drawing.Size(120, 20);
            this.tutarbox.TabIndex = 32;
            // 
            // tutarlabel
            // 
            this.tutarlabel.AutoSize = true;
            this.tutarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutarlabel.Location = new System.Drawing.Point(41, 26);
            this.tutarlabel.Name = "tutarlabel";
            this.tutarlabel.Size = new System.Drawing.Size(64, 15);
            this.tutarlabel.TabIndex = 31;
            this.tutarlabel.Text = "Alış Fiyat";
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.SystemColors.Control;
            this.kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.Location = new System.Drawing.Point(131, 224);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(120, 25);
            this.kapat.TabIndex = 44;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // KdvHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(269, 261);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.kdvdahiltutaribox);
            this.Controls.Add(this.kdvdahiltutarı);
            this.Controls.Add(this.kdvtutaribox);
            this.Controls.Add(this.kdvtutarılabel);
            this.Controls.Add(this.yuzdesekiz);
            this.Controls.Add(this.yuzdeonsekiz);
            this.Controls.Add(this.kdvlabel);
            this.Controls.Add(this.yuzdebir);
            this.Controls.Add(this.adetbox);
            this.Controls.Add(this.adetlabel);
            this.Controls.Add(this.tutarbox);
            this.Controls.Add(this.tutarlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KdvHesapla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KdvHesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.TextBox kdvdahiltutaribox;
        private System.Windows.Forms.Label kdvdahiltutarı;
        private System.Windows.Forms.TextBox kdvtutaribox;
        private System.Windows.Forms.Label kdvtutarılabel;
        private System.Windows.Forms.RadioButton yuzdesekiz;
        private System.Windows.Forms.RadioButton yuzdeonsekiz;
        private System.Windows.Forms.Label kdvlabel;
        private System.Windows.Forms.RadioButton yuzdebir;
        private System.Windows.Forms.TextBox adetbox;
        private System.Windows.Forms.Label adetlabel;
        private System.Windows.Forms.TextBox tutarbox;
        private System.Windows.Forms.Label tutarlabel;
        private System.Windows.Forms.Button kapat;
    }
}