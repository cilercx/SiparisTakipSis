namespace SiparisTakip.WinFormUI
{
    partial class GenelForm
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
            this.btnFaturaIslemleri = new System.Windows.Forms.Button();
            this.btnKullaniciIslemleri = new System.Windows.Forms.Button();
            this.btnStokIslemleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFaturaIslemleri
            // 
            this.btnFaturaIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturaIslemleri.Location = new System.Drawing.Point(17, 138);
            this.btnFaturaIslemleri.Name = "btnFaturaIslemleri";
            this.btnFaturaIslemleri.Size = new System.Drawing.Size(227, 221);
            this.btnFaturaIslemleri.TabIndex = 0;
            this.btnFaturaIslemleri.Text = "Fatura İşlemleri";
            this.btnFaturaIslemleri.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciIslemleri
            // 
            this.btnKullaniciIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciIslemleri.Location = new System.Drawing.Point(258, 138);
            this.btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            this.btnKullaniciIslemleri.Size = new System.Drawing.Size(227, 221);
            this.btnKullaniciIslemleri.TabIndex = 0;
            this.btnKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            this.btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            // 
            // btnStokIslemleri
            // 
            this.btnStokIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokIslemleri.Location = new System.Drawing.Point(502, 138);
            this.btnStokIslemleri.Name = "btnStokIslemleri";
            this.btnStokIslemleri.Size = new System.Drawing.Size(227, 221);
            this.btnStokIslemleri.TabIndex = 0;
            this.btnStokIslemleri.Text = "Stok İşlemleri";
            this.btnStokIslemleri.UseVisualStyleBackColor = true;
            this.btnStokIslemleri.Click += new System.EventHandler(this.btnStokIslemleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sipariş Takip Sistemi";
            // 
            // GenelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStokIslemleri);
            this.Controls.Add(this.btnKullaniciIslemleri);
            this.Controls.Add(this.btnFaturaIslemleri);
            this.Name = "GenelForm";
            this.Text = "GenelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFaturaIslemleri;
        private System.Windows.Forms.Button btnKullaniciIslemleri;
        private System.Windows.Forms.Button btnStokIslemleri;
        private System.Windows.Forms.Label label1;
    }
}