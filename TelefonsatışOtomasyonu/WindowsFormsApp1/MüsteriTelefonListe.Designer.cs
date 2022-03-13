
namespace WindowsFormsApp1
{
    partial class MüsteriTelefonListe
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
            this.telefonsilbutton = new System.Windows.Forms.Button();
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
            this.arabox.TextChanged += new System.EventHandler(this.arabox_TextChanged);
            // 
            // telefonsilbutton
            // 
            this.telefonsilbutton.BackColor = System.Drawing.SystemColors.Control;
            this.telefonsilbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.telefonsilbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.telefonsilbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonsilbutton.Location = new System.Drawing.Point(533, 307);
            this.telefonsilbutton.Name = "telefonsilbutton";
            this.telefonsilbutton.Size = new System.Drawing.Size(105, 26);
            this.telefonsilbutton.TabIndex = 9;
            this.telefonsilbutton.Text = "Telefon Sil";
            this.telefonsilbutton.UseVisualStyleBackColor = false;
            this.telefonsilbutton.Click += new System.EventHandler(this.telefonsilbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 35);
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
            this.button1.Location = new System.Drawing.Point(644, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MüsteriTelefonListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(764, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arayazi);
            this.Controls.Add(this.arabox);
            this.Controls.Add(this.telefonsilbutton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MüsteriTelefonListe";
            this.Text = "MüsteriTelefonListe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arayazi;
        private System.Windows.Forms.TextBox arabox;
        private System.Windows.Forms.Button telefonsilbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}