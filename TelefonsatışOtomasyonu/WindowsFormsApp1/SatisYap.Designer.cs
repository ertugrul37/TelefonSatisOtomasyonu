
namespace WindowsFormsApp1
{
    partial class SatisYap
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
            this.satisyapbuton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // arayazi
            // 
            this.arayazi.AutoSize = true;
            this.arayazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arayazi.Location = new System.Drawing.Point(24, 10);
            this.arayazi.Name = "arayazi";
            this.arayazi.Size = new System.Drawing.Size(32, 16);
            this.arayazi.TabIndex = 11;
            this.arayazi.Text = "Ara";
            // 
            // arabox
            // 
            this.arabox.Location = new System.Drawing.Point(62, 9);
            this.arabox.Name = "arabox";
            this.arabox.Size = new System.Drawing.Size(100, 20);
            this.arabox.TabIndex = 10;
            this.arabox.TextChanged += new System.EventHandler(this.arabox_TextChanged);
            // 
            // satisyapbuton
            // 
            this.satisyapbuton.BackColor = System.Drawing.SystemColors.Control;
            this.satisyapbuton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.satisyapbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisyapbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisyapbuton.Location = new System.Drawing.Point(536, 311);
            this.satisyapbuton.Name = "satisyapbuton";
            this.satisyapbuton.Size = new System.Drawing.Size(105, 26);
            this.satisyapbuton.TabIndex = 9;
            this.satisyapbuton.Text = "Satış Yap";
            this.satisyapbuton.UseVisualStyleBackColor = false;
            this.satisyapbuton.Click += new System.EventHandler(this.satisyapbuton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
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
            this.button1.Location = new System.Drawing.Point(647, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(764, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arayazi);
            this.Controls.Add(this.arabox);
            this.Controls.Add(this.satisyapbuton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatisYap";
            this.Text = "SatisYap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arayazi;
        private System.Windows.Forms.TextBox arabox;
        private System.Windows.Forms.Button satisyapbuton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}