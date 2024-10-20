namespace Soal_03
{
    partial class GuessNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessNumber));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tebak Angka [ 0 - 9 ] ?";
            // 
            // txtAngka
            // 
            this.txtAngka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAngka.Location = new System.Drawing.Point(26, 49);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(213, 22);
            this.txtAngka.TabIndex = 1;
            this.txtAngka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAngka.Enter += new System.EventHandler(this.txtAngka_Enter);
            this.txtAngka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngka_KeyPress);
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(348, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rolling";
            // 
            // lblRandom
            // 
            this.lblRandom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRandom.Location = new System.Drawing.Point(317, 49);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(137, 161);
            this.lblRandom.TabIndex = 3;
            this.lblRandom.Text = "0";
            this.lblRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(317, 232);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(137, 155);
            this.pbxFoto.TabIndex = 5;
            this.pbxFoto.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(496, 49);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 34);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(492, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "WIN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin
            // 
            this.lblWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblWin.Location = new System.Drawing.Point(492, 269);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(114, 23);
            this.lblWin.TabIndex = 9;
            this.lblWin.Text = "0";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLose
            // 
            this.lblLose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblLose.Location = new System.Drawing.Point(492, 349);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(114, 23);
            this.lblLose.TabIndex = 11;
            this.lblLose.Text = "0";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(492, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "LOSE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 395);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuessNumber";
            this.Text = "Guess A Number !!! [ Soal 03]";
            this.Load += new System.EventHandler(this.GuessNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label label7;
    }
}

