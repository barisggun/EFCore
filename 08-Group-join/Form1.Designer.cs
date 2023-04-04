namespace _08_Group_join
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYasaGoreGrupla = new System.Windows.Forms.Button();
            this.btnPersonelDepartmanBilgileri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(394, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnYasaGoreGrupla
            // 
            this.btnYasaGoreGrupla.Location = new System.Drawing.Point(12, 12);
            this.btnYasaGoreGrupla.Name = "btnYasaGoreGrupla";
            this.btnYasaGoreGrupla.Size = new System.Drawing.Size(178, 31);
            this.btnYasaGoreGrupla.TabIndex = 1;
            this.btnYasaGoreGrupla.Text = "Yaşa Göre Grupla";
            this.btnYasaGoreGrupla.UseVisualStyleBackColor = true;
            this.btnYasaGoreGrupla.Click += new System.EventHandler(this.btnYasaGoreGrupla_Click);
            // 
            // btnPersonelDepartmanBilgileri
            // 
            this.btnPersonelDepartmanBilgileri.Location = new System.Drawing.Point(12, 49);
            this.btnPersonelDepartmanBilgileri.Name = "btnPersonelDepartmanBilgileri";
            this.btnPersonelDepartmanBilgileri.Size = new System.Drawing.Size(178, 32);
            this.btnPersonelDepartmanBilgileri.TabIndex = 1;
            this.btnPersonelDepartmanBilgileri.Text = "Personel Departman Bilgileri";
            this.btnPersonelDepartmanBilgileri.UseVisualStyleBackColor = true;
            this.btnPersonelDepartmanBilgileri.Click += new System.EventHandler(this.btnPersonelDepartmanBilgileri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnPersonelDepartmanBilgileri);
            this.Controls.Add(this.btnYasaGoreGrupla);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnYasaGoreGrupla;
        private Button btnPersonelDepartmanBilgileri;
    }
}