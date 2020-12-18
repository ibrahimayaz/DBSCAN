namespace DBSCAN
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
            this.dg_sonucTablosu = new System.Windows.Forms.DataGridView();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txt_minPts = new System.Windows.Forms.TextBox();
            this.txt_eps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_veriSetiniSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_ayrac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_kumeBilgileri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sonucTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_kumeBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_sonucTablosu
            // 
            this.dg_sonucTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sonucTablosu.Location = new System.Drawing.Point(9, 26);
            this.dg_sonucTablosu.Margin = new System.Windows.Forms.Padding(2);
            this.dg_sonucTablosu.Name = "dg_sonucTablosu";
            this.dg_sonucTablosu.RowHeadersWidth = 51;
            this.dg_sonucTablosu.RowTemplate.Height = 24;
            this.dg_sonucTablosu.Size = new System.Drawing.Size(773, 339);
            this.dg_sonucTablosu.TabIndex = 0;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(810, 114);
            this.btn_hesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(64, 24);
            this.btn_hesapla.TabIndex = 1;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txt_minPts
            // 
            this.txt_minPts.Location = new System.Drawing.Point(788, 91);
            this.txt_minPts.Margin = new System.Windows.Forms.Padding(2);
            this.txt_minPts.Name = "txt_minPts";
            this.txt_minPts.Size = new System.Drawing.Size(53, 20);
            this.txt_minPts.TabIndex = 3;
            // 
            // txt_eps
            // 
            this.txt_eps.Location = new System.Drawing.Point(844, 91);
            this.txt_eps.Margin = new System.Windows.Forms.Padding(2);
            this.txt_eps.Name = "txt_eps";
            this.txt_eps.Size = new System.Drawing.Size(53, 20);
            this.txt_eps.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MinPts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eps";
            // 
            // btn_veriSetiniSec
            // 
            this.btn_veriSetiniSec.Location = new System.Drawing.Point(824, 26);
            this.btn_veriSetiniSec.Margin = new System.Windows.Forms.Padding(2);
            this.btn_veriSetiniSec.Name = "btn_veriSetiniSec";
            this.btn_veriSetiniSec.Size = new System.Drawing.Size(72, 34);
            this.btn_veriSetiniSec.TabIndex = 7;
            this.btn_veriSetiniSec.Text = "Veriyi Seç";
            this.btn_veriSetiniSec.UseVisualStyleBackColor = true;
            this.btn_veriSetiniSec.Click += new System.EventHandler(this.btn_veriSetiniSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_ayrac
            // 
            this.txt_ayrac.Location = new System.Drawing.Point(789, 38);
            this.txt_ayrac.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ayrac.MaxLength = 1;
            this.txt_ayrac.Name = "txt_ayrac";
            this.txt_ayrac.Size = new System.Drawing.Size(32, 20);
            this.txt_ayrac.TabIndex = 8;
            this.txt_ayrac.Text = ";";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ayraç";
            // 
            // dg_kumeBilgileri
            // 
            this.dg_kumeBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_kumeBilgileri.Location = new System.Drawing.Point(9, 384);
            this.dg_kumeBilgileri.Name = "dg_kumeBilgileri";
            this.dg_kumeBilgileri.Size = new System.Drawing.Size(264, 225);
            this.dg_kumeBilgileri.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 686);
            this.Controls.Add(this.dg_kumeBilgileri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ayrac);
            this.Controls.Add(this.btn_veriSetiniSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_eps);
            this.Controls.Add(this.txt_minPts);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.dg_sonucTablosu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_sonucTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_kumeBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_sonucTablosu;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_minPts;
        private System.Windows.Forms.TextBox txt_eps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_veriSetiniSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_ayrac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_kumeBilgileri;
    }
}

