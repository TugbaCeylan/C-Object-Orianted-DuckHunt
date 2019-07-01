namespace WFADuckHunt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlHavaSahasi = new System.Windows.Forms.Panel();
            this.tmrYatay = new System.Windows.Forms.Timer(this.components);
            this.tmrDikey = new System.Windows.Forms.Timer(this.components);
            this.tmrDusus = new System.Windows.Forms.Timer(this.components);
            this.tmrKopekCikis = new System.Windows.Forms.Timer(this.components);
            this.tmrKopekGiris = new System.Windows.Forms.Timer(this.components);
            this.lblToplamAtis = new System.Windows.Forms.Label();
            this.lblVurulanOrdek = new System.Windows.Forms.Label();
            this.flpAtisHakki = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamOrdek = new System.Windows.Forms.Label();
            this.lblKacanOrdek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlHavaSahasi
            // 
            this.pnlHavaSahasi.BackColor = System.Drawing.Color.Transparent;
            this.pnlHavaSahasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHavaSahasi.Location = new System.Drawing.Point(0, 0);
            this.pnlHavaSahasi.Name = "pnlHavaSahasi";
            this.pnlHavaSahasi.Size = new System.Drawing.Size(903, 394);
            this.pnlHavaSahasi.TabIndex = 0;
            this.pnlHavaSahasi.Click += new System.EventHandler(this.pnlHavaSahasi_Click);
            this.pnlHavaSahasi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHavaSahasi_Paint);
            // 
            // tmrYatay
            // 
            this.tmrYatay.Interval = 10;
            this.tmrYatay.Tick += new System.EventHandler(this.tmrYatay_Tick);
            // 
            // tmrDikey
            // 
            this.tmrDikey.Interval = 10;
            this.tmrDikey.Tick += new System.EventHandler(this.tmrDikey_Tick);
            // 
            // tmrDusus
            // 
            this.tmrDusus.Interval = 10;
            this.tmrDusus.Tick += new System.EventHandler(this.tmrDusus_Tick);
            // 
            // tmrKopekCikis
            // 
            this.tmrKopekCikis.Interval = 10;
            this.tmrKopekCikis.Tick += new System.EventHandler(this.tmrKopekCikis_Tick);
            // 
            // tmrKopekGiris
            // 
            this.tmrKopekGiris.Interval = 10;
            this.tmrKopekGiris.Tick += new System.EventHandler(this.tmrKopekGiris_Tick);
            // 
            // lblToplamAtis
            // 
            this.lblToplamAtis.AutoSize = true;
            this.lblToplamAtis.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamAtis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAtis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplamAtis.Location = new System.Drawing.Point(751, 464);
            this.lblToplamAtis.Name = "lblToplamAtis";
            this.lblToplamAtis.Size = new System.Drawing.Size(128, 20);
            this.lblToplamAtis.TabIndex = 1;
            this.lblToplamAtis.Text = "Toplam Atış : 0";
            // 
            // lblVurulanOrdek
            // 
            this.lblVurulanOrdek.AutoSize = true;
            this.lblVurulanOrdek.BackColor = System.Drawing.Color.Transparent;
            this.lblVurulanOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVurulanOrdek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVurulanOrdek.Location = new System.Drawing.Point(730, 497);
            this.lblVurulanOrdek.Name = "lblVurulanOrdek";
            this.lblVurulanOrdek.Size = new System.Drawing.Size(149, 20);
            this.lblVurulanOrdek.TabIndex = 1;
            this.lblVurulanOrdek.Text = "Vurulan Örnek : 0";
            // 
            // flpAtisHakki
            // 
            this.flpAtisHakki.BackColor = System.Drawing.Color.Transparent;
            this.flpAtisHakki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAtisHakki.Location = new System.Drawing.Point(12, 487);
            this.flpAtisHakki.Name = "flpAtisHakki";
            this.flpAtisHakki.Size = new System.Drawing.Size(139, 30);
            this.flpAtisHakki.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atış Hakkı";
            // 
            // lblToplamOrdek
            // 
            this.lblToplamOrdek.AutoSize = true;
            this.lblToplamOrdek.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOrdek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplamOrdek.Location = new System.Drawing.Point(437, 464);
            this.lblToplamOrdek.Name = "lblToplamOrdek";
            this.lblToplamOrdek.Size = new System.Drawing.Size(145, 20);
            this.lblToplamOrdek.TabIndex = 1;
            this.lblToplamOrdek.Text = "Toplam Ördek : 0";
            // 
            // lblKacanOrdek
            // 
            this.lblKacanOrdek.AutoSize = true;
            this.lblKacanOrdek.BackColor = System.Drawing.Color.Transparent;
            this.lblKacanOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKacanOrdek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKacanOrdek.Location = new System.Drawing.Point(445, 497);
            this.lblKacanOrdek.Name = "lblKacanOrdek";
            this.lblKacanOrdek.Size = new System.Drawing.Size(137, 20);
            this.lblKacanOrdek.TabIndex = 1;
            this.lblKacanOrdek.Text = "Kaçan Ördek : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFADuckHunt.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 541);
            this.Controls.Add(this.flpAtisHakki);
            this.Controls.Add(this.lblKacanOrdek);
            this.Controls.Add(this.lblToplamOrdek);
            this.Controls.Add(this.lblVurulanOrdek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamAtis);
            this.Controls.Add(this.pnlHavaSahasi);
            this.MaximumSize = new System.Drawing.Size(919, 580);
            this.MinimumSize = new System.Drawing.Size(919, 580);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHavaSahasi;
        private System.Windows.Forms.Timer tmrYatay;
        private System.Windows.Forms.Timer tmrDikey;
        private System.Windows.Forms.Timer tmrDusus;
        private System.Windows.Forms.Timer tmrKopekCikis;
        private System.Windows.Forms.Timer tmrKopekGiris;
        private System.Windows.Forms.Label lblToplamAtis;
        private System.Windows.Forms.Label lblVurulanOrdek;
        private System.Windows.Forms.FlowLayoutPanel flpAtisHakki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamOrdek;
        private System.Windows.Forms.Label lblKacanOrdek;
    }
}

