
namespace WindowsFormsApp1
{
    partial class SatisListe
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
            this.arayazi = new System.Windows.Forms.Label();
            this.arabox = new System.Windows.Forms.TextBox();
            this.satissil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // arayazi
            // 
            this.arayazi.AutoSize = true;
            this.arayazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arayazi.Location = new System.Drawing.Point(12, 9);
            this.arayazi.Name = "arayazi";
            this.arayazi.Size = new System.Drawing.Size(32, 16);
            this.arayazi.TabIndex = 11;
            this.arayazi.Text = "Ara";
            // 
            // arabox
            // 
            this.arabox.Location = new System.Drawing.Point(50, 8);
            this.arabox.Name = "arabox";
            this.arabox.Size = new System.Drawing.Size(100, 20);
            this.arabox.TabIndex = 10;
            // 
            // satissil
            // 
            this.satissil.BackColor = System.Drawing.SystemColors.Control;
            this.satissil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.satissil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satissil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satissil.Location = new System.Drawing.Point(536, 310);
            this.satissil.Name = "satissil";
            this.satissil.Size = new System.Drawing.Size(105, 26);
            this.satissil.TabIndex = 9;
            this.satissil.Text = "Satış Temizle";
            this.satissil.UseVisualStyleBackColor = false;
            this.satissil.Click += new System.EventHandler(this.satissil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 266);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(647, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SatisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(764, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arayazi);
            this.Controls.Add(this.arabox);
            this.Controls.Add(this.satissil);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatisListe";
            this.Text = "SatisListe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arayazi;
        private System.Windows.Forms.TextBox arabox;
        private System.Windows.Forms.Button satissil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}