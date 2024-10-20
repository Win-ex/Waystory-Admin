namespace Pertemuan03
{
    partial class Form
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
            this.lblHargaBeli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtPersen = new System.Windows.Forms.TextBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblPotongan = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHargaBeli
            // 
            this.lblHargaBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaBeli.Location = new System.Drawing.Point(26, 9);
            this.lblHargaBeli.Name = "lblHargaBeli";
            this.lblHargaBeli.Size = new System.Drawing.Size(161, 31);
            this.lblHargaBeli.TabIndex = 0;
            this.lblHargaBeli.Text = "Harga Beli/Unit (Rp)";
            this.lblHargaBeli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Unit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potongan %";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Keterangan";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHarga
            // 
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(209, 9);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(250, 22);
            this.txtHarga.TabIndex = 5;
            // 
            // txtJumlah
            // 
            this.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(209, 44);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(250, 22);
            this.txtJumlah.TabIndex = 6;
            // 
            // txtPersen
            // 
            this.txtPersen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersen.Location = new System.Drawing.Point(209, 84);
            this.txtPersen.Name = "txtPersen";
            this.txtPersen.Size = new System.Drawing.Size(104, 22);
            this.txtPersen.TabIndex = 7;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.Location = new System.Drawing.Point(27, 164);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(571, 42);
            this.lblKeterangan.TabIndex = 8;
            this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPotongan
            // 
            this.lblPotongan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPotongan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPotongan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotongan.Location = new System.Drawing.Point(331, 84);
            this.lblPotongan.Name = "lblPotongan";
            this.lblPotongan.Size = new System.Drawing.Size(267, 30);
            this.lblPotongan.TabIndex = 9;
            this.lblPotongan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHitung
            // 
            this.btnHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.Location = new System.Drawing.Point(465, 9);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(133, 65);
            this.btnHitung.TabIndex = 10;
            this.btnHitung.Text = "&Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 215);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lblPotongan);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.txtPersen);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHargaBeli);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perhitungan";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHargaBeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtPersen;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblPotongan;
        private System.Windows.Forms.Button btnHitung;
    }
}

