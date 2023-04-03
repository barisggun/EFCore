namespace _03_ExtensionMethodIleLinq
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnYaileBitenler = new System.Windows.Forms.Button();
            this.btnAileBaslayanlar = new System.Windows.Forms.Button();
            this.btnZdenAyaSirala = new System.Windows.Forms.Button();
            this.btnAdanZyeSirala = new System.Windows.Forms.Button();
            this.btnAltidanFazlaOlanlar = new System.Windows.Forms.Button();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(382, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 424);
            this.listBox1.TabIndex = 8;
            // 
            // btnYaileBitenler
            // 
            this.btnYaileBitenler.Location = new System.Drawing.Point(12, 158);
            this.btnYaileBitenler.Name = "btnYaileBitenler";
            this.btnYaileBitenler.Size = new System.Drawing.Size(364, 23);
            this.btnYaileBitenler.TabIndex = 2;
            this.btnYaileBitenler.Text = "Ya ile bitenler";
            this.btnYaileBitenler.UseVisualStyleBackColor = true;
            this.btnYaileBitenler.Click += new System.EventHandler(this.btnYaileBitenler_Click);
            // 
            // btnAileBaslayanlar
            // 
            this.btnAileBaslayanlar.Location = new System.Drawing.Point(12, 129);
            this.btnAileBaslayanlar.Name = "btnAileBaslayanlar";
            this.btnAileBaslayanlar.Size = new System.Drawing.Size(364, 23);
            this.btnAileBaslayanlar.TabIndex = 3;
            this.btnAileBaslayanlar.Text = "A ile Başlayanlar";
            this.btnAileBaslayanlar.UseVisualStyleBackColor = true;
            this.btnAileBaslayanlar.Click += new System.EventHandler(this.btnAileBaslayanlar_Click);
            // 
            // btnZdenAyaSirala
            // 
            this.btnZdenAyaSirala.Location = new System.Drawing.Point(12, 100);
            this.btnZdenAyaSirala.Name = "btnZdenAyaSirala";
            this.btnZdenAyaSirala.Size = new System.Drawing.Size(364, 23);
            this.btnZdenAyaSirala.TabIndex = 4;
            this.btnZdenAyaSirala.Text = "Z\'den A\'ya Sırala";
            this.btnZdenAyaSirala.UseVisualStyleBackColor = true;
            this.btnZdenAyaSirala.Click += new System.EventHandler(this.btnZdenAyaSirala_Click);
            // 
            // btnAdanZyeSirala
            // 
            this.btnAdanZyeSirala.Location = new System.Drawing.Point(12, 71);
            this.btnAdanZyeSirala.Name = "btnAdanZyeSirala";
            this.btnAdanZyeSirala.Size = new System.Drawing.Size(364, 23);
            this.btnAdanZyeSirala.TabIndex = 5;
            this.btnAdanZyeSirala.Text = "A\'dan Z\'ye Sırala";
            this.btnAdanZyeSirala.UseVisualStyleBackColor = true;
            this.btnAdanZyeSirala.Click += new System.EventHandler(this.btnAdanZyeSirala_Click);
            // 
            // btnAltidanFazlaOlanlar
            // 
            this.btnAltidanFazlaOlanlar.Location = new System.Drawing.Point(12, 42);
            this.btnAltidanFazlaOlanlar.Name = "btnAltidanFazlaOlanlar";
            this.btnAltidanFazlaOlanlar.Size = new System.Drawing.Size(364, 23);
            this.btnAltidanFazlaOlanlar.TabIndex = 6;
            this.btnAltidanFazlaOlanlar.Text = "6 Karakterden fazla olanlar";
            this.btnAltidanFazlaOlanlar.UseVisualStyleBackColor = true;
            this.btnAltidanFazlaOlanlar.Click += new System.EventHandler(this.btnAltidanFazlaOlanlar_Click);
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.Location = new System.Drawing.Point(12, 13);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(364, 23);
            this.btnTumunuListele.TabIndex = 7;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = true;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnYaileBitenler);
            this.Controls.Add(this.btnAileBaslayanlar);
            this.Controls.Add(this.btnZdenAyaSirala);
            this.Controls.Add(this.btnAdanZyeSirala);
            this.Controls.Add(this.btnAltidanFazlaOlanlar);
            this.Controls.Add(this.btnTumunuListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button btnYaileBitenler;
        private Button btnAileBaslayanlar;
        private Button btnZdenAyaSirala;
        private Button btnAdanZyeSirala;
        private Button btnAltidanFazlaOlanlar;
        private Button btnTumunuListele;
    }
}