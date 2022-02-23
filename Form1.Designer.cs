
namespace Proje5._39_AdamAsmacaOyunu
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
            this.pbAdamAsilmasi = new System.Windows.Forms.PictureBox();
            this.pnlSoru = new System.Windows.Forms.Panel();
            this.flpHarfler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBasla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdamAsilmasi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdamAsilmasi
            // 
            this.pbAdamAsilmasi.Location = new System.Drawing.Point(664, 12);
            this.pbAdamAsilmasi.Name = "pbAdamAsilmasi";
            this.pbAdamAsilmasi.Size = new System.Drawing.Size(513, 636);
            this.pbAdamAsilmasi.TabIndex = 0;
            this.pbAdamAsilmasi.TabStop = false;
            // 
            // pnlSoru
            // 
            this.pnlSoru.Location = new System.Drawing.Point(12, 12);
            this.pnlSoru.Name = "pnlSoru";
            this.pnlSoru.Size = new System.Drawing.Size(646, 202);
            this.pnlSoru.TabIndex = 1;
            // 
            // flpHarfler
            // 
            this.flpHarfler.Location = new System.Drawing.Point(12, 220);
            this.flpHarfler.Name = "flpHarfler";
            this.flpHarfler.Size = new System.Drawing.Size(646, 257);
            this.flpHarfler.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(13, 484);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(152, 58);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 677);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.flpHarfler);
            this.Controls.Add(this.pnlSoru);
            this.Controls.Add(this.pbAdamAsilmasi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdamAsilmasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdamAsilmasi;
        private System.Windows.Forms.Panel pnlSoru;
        private System.Windows.Forms.FlowLayoutPanel flpHarfler;
        private System.Windows.Forms.Button btnBasla;
    }
}

