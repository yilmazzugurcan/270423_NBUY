namespace _270423_NBUY
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTanim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btnTedarikci = new System.Windows.Forms.Button();
            this.txtSirketAd = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.btnTedarikciEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(440, 71);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 20);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(52, 71);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(186, 71);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(100, 20);
            this.txtTanim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tanım";
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(52, 195);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(488, 150);
            this.dgvListe.TabIndex = 7;
            // 
            // btnTedarikci
            // 
            this.btnTedarikci.Location = new System.Drawing.Point(578, 71);
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.Size = new System.Drawing.Size(100, 20);
            this.btnTedarikci.TabIndex = 8;
            this.btnTedarikci.Text = "Tedarikciler";
            this.btnTedarikci.UseVisualStyleBackColor = true;
            this.btnTedarikci.Click += new System.EventHandler(this.btnTedarikci_Click);
            // 
            // txtSirketAd
            // 
            this.txtSirketAd.Location = new System.Drawing.Point(98, 167);
            this.txtSirketAd.Name = "txtSirketAd";
            this.txtSirketAd.Size = new System.Drawing.Size(100, 20);
            this.txtSirketAd.TabIndex = 9;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(224, 167);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 10;
            // 
            // btnTedarikciEkle
            // 
            this.btnTedarikciEkle.Location = new System.Drawing.Point(360, 165);
            this.btnTedarikciEkle.Name = "btnTedarikciEkle";
            this.btnTedarikciEkle.Size = new System.Drawing.Size(107, 23);
            this.btnTedarikciEkle.TabIndex = 11;
            this.btnTedarikciEkle.Text = "Tedarikci Ekle";
            this.btnTedarikciEkle.UseVisualStyleBackColor = true;
            this.btnTedarikciEkle.Click += new System.EventHandler(this.btnTedarikciEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTedarikciEkle);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtSirketAd);
            this.Controls.Add(this.btnTedarikci);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTanim);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTanim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnTedarikci;
        private System.Windows.Forms.TextBox txtSirketAd;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Button btnTedarikciEkle;
    }
}

