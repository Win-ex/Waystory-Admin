namespace ProgramPassword
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnValidasi = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(169, 20);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Masukkan Password Anda :\r\n";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidasi
            // 
            this.btnValidasi.Location = new System.Drawing.Point(16, 60);
            this.btnValidasi.Name = "btnValidasi";
            this.btnValidasi.Size = new System.Drawing.Size(91, 30);
            this.btnValidasi.TabIndex = 2;
            this.btnValidasi.Text = "&Validasi";
            this.btnValidasi.UseVisualStyleBackColor = true;
            this.btnValidasi.Click += new System.EventHandler(this.btnValidasi_Click);
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Location = new System.Drawing.Point(16, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '*';
            this.txtInput.Size = new System.Drawing.Size(431, 22);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // btnMasuk
            // 
            this.btnMasuk.Location = new System.Drawing.Point(186, 60);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(91, 30);
            this.btnMasuk.TabIndex = 3;
            this.btnMasuk.Text = "&Masuk";
            this.btnMasuk.UseVisualStyleBackColor = true;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(356, 60);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(91, 30);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "&Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.Location = new System.Drawing.Point(15, 107);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(432, 26);
            this.lblKeterangan.TabIndex = 5;
            this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(382, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 20);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "( count )";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnValidasi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 152);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnValidasi);
            this.Controls.Add(this.lblJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validasi Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnValidasi;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblCount;
    }
}

