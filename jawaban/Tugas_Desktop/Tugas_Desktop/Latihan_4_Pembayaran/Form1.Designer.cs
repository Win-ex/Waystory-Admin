namespace Latihan_4_Pembayaran
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
            this.lblPembelian = new System.Windows.Forms.Label();
            this.txtPembelian = new System.Windows.Forms.TextBox();
            this.lblPembayarn = new System.Windows.Forms.Label();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoKredit = new System.Windows.Forms.RadioButton();
            this.grpCash = new System.Windows.Forms.GroupBox();
            this.lblNominalDiskon = new System.Windows.Forms.Label();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNominal = new System.Windows.Forms.Label();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.grpKredit = new System.Windows.Forms.GroupBox();
            this.lblBesaranCicilan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJumlahCicilan = new System.Windows.Forms.TextBox();
            this.lblBesarCicilan = new System.Windows.Forms.Label();
            this.lblJumlahCicilan = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.grpCash.SuspendLayout();
            this.grpKredit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPembelian
            // 
            this.lblPembelian.Location = new System.Drawing.Point(12, 21);
            this.lblPembelian.Name = "lblPembelian";
            this.lblPembelian.Size = new System.Drawing.Size(172, 23);
            this.lblPembelian.TabIndex = 0;
            this.lblPembelian.Text = "Masukkan Pembelian :";
            this.lblPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPembelian
            // 
            this.txtPembelian.Location = new System.Drawing.Point(190, 22);
            this.txtPembelian.Name = "txtPembelian";
            this.txtPembelian.Size = new System.Drawing.Size(170, 22);
            this.txtPembelian.TabIndex = 2;
            this.txtPembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPembelian.TextChanged += new System.EventHandler(this.txtPembelian_TextChanged);
            this.txtPembelian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPembelian_KeyPress);
            // 
            // lblPembayarn
            // 
            this.lblPembayarn.Location = new System.Drawing.Point(12, 76);
            this.lblPembayarn.Name = "lblPembayarn";
            this.lblPembayarn.Size = new System.Drawing.Size(172, 23);
            this.lblPembayarn.TabIndex = 3;
            this.lblPembayarn.Text = "Metode Pembayaran";
            this.lblPembayarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(27, 123);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(59, 20);
            this.rdoCash.TabIndex = 4;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // rdoKredit
            // 
            this.rdoKredit.AutoSize = true;
            this.rdoKredit.Location = new System.Drawing.Point(430, 123);
            this.rdoKredit.Name = "rdoKredit";
            this.rdoKredit.Size = new System.Drawing.Size(62, 20);
            this.rdoKredit.TabIndex = 5;
            this.rdoKredit.TabStop = true;
            this.rdoKredit.Text = "Kredit";
            this.rdoKredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoKredit.UseVisualStyleBackColor = true;
            this.rdoKredit.CheckedChanged += new System.EventHandler(this.rdoKredit_CheckedChanged);
            // 
            // grpCash
            // 
            this.grpCash.Controls.Add(this.lblNominalDiskon);
            this.grpCash.Controls.Add(this.lblTotalCash);
            this.grpCash.Controls.Add(this.txtDiskon);
            this.grpCash.Controls.Add(this.lblTotal);
            this.grpCash.Controls.Add(this.lblNominal);
            this.grpCash.Controls.Add(this.lblDiskon);
            this.grpCash.Location = new System.Drawing.Point(27, 160);
            this.grpCash.Name = "grpCash";
            this.grpCash.Size = new System.Drawing.Size(329, 147);
            this.grpCash.TabIndex = 6;
            this.grpCash.TabStop = false;
            this.grpCash.Text = "Cash";
            // 
            // lblNominalDiskon
            // 
            this.lblNominalDiskon.Location = new System.Drawing.Point(179, 70);
            this.lblNominalDiskon.Name = "lblNominalDiskon";
            this.lblNominalDiskon.Size = new System.Drawing.Size(132, 22);
            this.lblNominalDiskon.TabIndex = 6;
            this.lblNominalDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.Location = new System.Drawing.Point(179, 109);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(132, 22);
            this.lblTotalCash.TabIndex = 5;
            this.lblTotalCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiskon
            // 
            this.txtDiskon.Location = new System.Drawing.Point(179, 31);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(132, 22);
            this.txtDiskon.TabIndex = 3;
            this.txtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiskon.TextChanged += new System.EventHandler(this.txtPembelian_TextChanged);
            this.txtDiskon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiskon_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 115);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Location = new System.Drawing.Point(26, 73);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(106, 16);
            this.lblNominal.TabIndex = 1;
            this.lblNominal.Text = "Nominal diskon :";
            this.lblNominal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiskon
            // 
            this.lblDiskon.Location = new System.Drawing.Point(26, 30);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(147, 23);
            this.lblDiskon.TabIndex = 0;
            this.lblDiskon.Text = "Masukkan diskon (%) :";
            this.lblDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpKredit
            // 
            this.grpKredit.Controls.Add(this.lblBesaranCicilan);
            this.grpKredit.Controls.Add(this.label6);
            this.grpKredit.Controls.Add(this.txtJumlahCicilan);
            this.grpKredit.Controls.Add(this.lblBesarCicilan);
            this.grpKredit.Controls.Add(this.lblJumlahCicilan);
            this.grpKredit.Location = new System.Drawing.Point(423, 160);
            this.grpKredit.Name = "grpKredit";
            this.grpKredit.Size = new System.Drawing.Size(329, 147);
            this.grpKredit.TabIndex = 7;
            this.grpKredit.TabStop = false;
            this.grpKredit.Text = "Kredit";
            // 
            // lblBesaranCicilan
            // 
            this.lblBesaranCicilan.Location = new System.Drawing.Point(179, 67);
            this.lblBesaranCicilan.Name = "lblBesaranCicilan";
            this.lblBesaranCicilan.Size = new System.Drawing.Size(88, 22);
            this.lblBesaranCicilan.TabIndex = 6;
            this.lblBesaranCicilan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(267, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "kali";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJumlahCicilan
            // 
            this.txtJumlahCicilan.Location = new System.Drawing.Point(179, 31);
            this.txtJumlahCicilan.Name = "txtJumlahCicilan";
            this.txtJumlahCicilan.Size = new System.Drawing.Size(88, 22);
            this.txtJumlahCicilan.TabIndex = 3;
            this.txtJumlahCicilan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJumlahCicilan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPembelian_KeyPress);
            // 
            // lblBesarCicilan
            // 
            this.lblBesarCicilan.AutoSize = true;
            this.lblBesarCicilan.Location = new System.Drawing.Point(26, 73);
            this.lblBesarCicilan.Name = "lblBesarCicilan";
            this.lblBesarCicilan.Size = new System.Drawing.Size(90, 16);
            this.lblBesarCicilan.TabIndex = 1;
            this.lblBesarCicilan.Text = "Besar cicilan :";
            this.lblBesarCicilan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumlahCicilan
            // 
            this.lblJumlahCicilan.AutoSize = true;
            this.lblJumlahCicilan.Location = new System.Drawing.Point(26, 30);
            this.lblJumlahCicilan.Name = "lblJumlahCicilan";
            this.lblJumlahCicilan.Size = new System.Drawing.Size(97, 16);
            this.lblJumlahCicilan.TabIndex = 0;
            this.lblJumlahCicilan.Text = "Jumlah cicilan :";
            this.lblJumlahCicilan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(461, 31);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(229, 56);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 354);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.grpKredit);
            this.Controls.Add(this.grpCash);
            this.Controls.Add(this.rdoKredit);
            this.Controls.Add(this.rdoCash);
            this.Controls.Add(this.lblPembayarn);
            this.Controls.Add(this.txtPembelian);
            this.Controls.Add(this.lblPembelian);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCash.ResumeLayout(false);
            this.grpCash.PerformLayout();
            this.grpKredit.ResumeLayout(false);
            this.grpKredit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPembelian;
        private System.Windows.Forms.TextBox txtPembelian;
        private System.Windows.Forms.Label lblPembayarn;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoKredit;
        private System.Windows.Forms.GroupBox grpCash;
        private System.Windows.Forms.Label lblDiskon;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.GroupBox grpKredit;
        private System.Windows.Forms.TextBox txtJumlahCicilan;
        private System.Windows.Forms.Label lblBesarCicilan;
        private System.Windows.Forms.Label lblJumlahCicilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Label lblBesaranCicilan;
        private System.Windows.Forms.Label lblNominalDiskon;
    }
}

