namespace tugas_5_pizza
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
            this.grpUkuran = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.grpPinggiran = new System.Windows.Forms.GroupBox();
            this.rdoNugget = new System.Windows.Forms.RadioButton();
            this.rdoSosis = new System.Windows.Forms.RadioButton();
            this.rdoKeju = new System.Windows.Forms.RadioButton();
            this.grpTopping = new System.Windows.Forms.GroupBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.rdoTakeOut = new System.Windows.Forms.RadioButton();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnKosong = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpUkuran.SuspendLayout();
            this.grpPinggiran.SuspendLayout();
            this.grpTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUkuran
            // 
            this.grpUkuran.Controls.Add(this.rdoLarge);
            this.grpUkuran.Controls.Add(this.rdoMedium);
            this.grpUkuran.Controls.Add(this.rdoSmall);
            this.grpUkuran.Location = new System.Drawing.Point(12, 12);
            this.grpUkuran.Name = "grpUkuran";
            this.grpUkuran.Size = new System.Drawing.Size(215, 157);
            this.grpUkuran.TabIndex = 0;
            this.grpUkuran.TabStop = false;
            this.grpUkuran.Text = "Ukuran";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(28, 113);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(63, 20);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(28, 75);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(76, 20);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(28, 37);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(62, 20);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // grpPinggiran
            // 
            this.grpPinggiran.Controls.Add(this.rdoNugget);
            this.grpPinggiran.Controls.Add(this.rdoSosis);
            this.grpPinggiran.Controls.Add(this.rdoKeju);
            this.grpPinggiran.Location = new System.Drawing.Point(12, 197);
            this.grpPinggiran.Name = "grpPinggiran";
            this.grpPinggiran.Size = new System.Drawing.Size(215, 157);
            this.grpPinggiran.TabIndex = 3;
            this.grpPinggiran.TabStop = false;
            this.grpPinggiran.Text = "Pinggiran";
            // 
            // rdoNugget
            // 
            this.rdoNugget.AutoSize = true;
            this.rdoNugget.Location = new System.Drawing.Point(28, 113);
            this.rdoNugget.Name = "rdoNugget";
            this.rdoNugget.Size = new System.Drawing.Size(72, 20);
            this.rdoNugget.TabIndex = 2;
            this.rdoNugget.Text = "Nugget";
            this.rdoNugget.UseVisualStyleBackColor = true;
            this.rdoNugget.CheckedChanged += new System.EventHandler(this.rdoKeju_CheckedChanged);
            // 
            // rdoSosis
            // 
            this.rdoSosis.AutoSize = true;
            this.rdoSosis.Location = new System.Drawing.Point(28, 75);
            this.rdoSosis.Name = "rdoSosis";
            this.rdoSosis.Size = new System.Drawing.Size(62, 20);
            this.rdoSosis.TabIndex = 1;
            this.rdoSosis.Text = "Sosis";
            this.rdoSosis.UseVisualStyleBackColor = true;
            this.rdoSosis.CheckedChanged += new System.EventHandler(this.rdoKeju_CheckedChanged);
            // 
            // rdoKeju
            // 
            this.rdoKeju.AutoSize = true;
            this.rdoKeju.Location = new System.Drawing.Point(28, 37);
            this.rdoKeju.Name = "rdoKeju";
            this.rdoKeju.Size = new System.Drawing.Size(54, 20);
            this.rdoKeju.TabIndex = 0;
            this.rdoKeju.Text = "Keju";
            this.rdoKeju.UseVisualStyleBackColor = true;
            this.rdoKeju.CheckedChanged += new System.EventHandler(this.rdoKeju_CheckedChanged);
            // 
            // grpTopping
            // 
            this.grpTopping.Controls.Add(this.chkTomatoes);
            this.grpTopping.Controls.Add(this.chkGreenPeppers);
            this.grpTopping.Controls.Add(this.chkOnions);
            this.grpTopping.Controls.Add(this.chkBlackOlives);
            this.grpTopping.Controls.Add(this.chkMushrooms);
            this.grpTopping.Controls.Add(this.chkExtraCheese);
            this.grpTopping.Location = new System.Drawing.Point(261, 12);
            this.grpTopping.Name = "grpTopping";
            this.grpTopping.Size = new System.Drawing.Size(352, 156);
            this.grpTopping.TabIndex = 4;
            this.grpTopping.TabStop = false;
            this.grpTopping.Text = "Topping";
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(192, 104);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 5;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(192, 68);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 4;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(192, 32);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(71, 20);
            this.chkOnions.TabIndex = 3;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(35, 104);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(104, 20);
            this.chkBlackOlives.TabIndex = 2;
            this.chkBlackOlives.Text = "Black Olives";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(35, 68);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(35, 32);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.Location = new System.Drawing.Point(296, 224);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(61, 20);
            this.rdoEatIn.TabIndex = 5;
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = true;
            this.rdoEatIn.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // rdoTakeOut
            // 
            this.rdoTakeOut.AutoSize = true;
            this.rdoTakeOut.Location = new System.Drawing.Point(453, 224);
            this.rdoTakeOut.Name = "rdoTakeOut";
            this.rdoTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rdoTakeOut.TabIndex = 6;
            this.rdoTakeOut.Text = "Take Out";
            this.rdoTakeOut.UseVisualStyleBackColor = true;
            this.rdoTakeOut.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(261, 281);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(352, 28);
            this.btnPesan.TabIndex = 7;
            this.btnPesan.Text = "&Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnKosong
            // 
            this.btnKosong.Location = new System.Drawing.Point(261, 326);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(170, 28);
            this.btnKosong.TabIndex = 8;
            this.btnKosong.Text = "&Kosong";
            this.btnKosong.UseVisualStyleBackColor = true;
            this.btnKosong.Click += new System.EventHandler(this.btnKosong_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(443, 326);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(170, 28);
            this.btnKeluar.TabIndex = 9;
            this.btnKeluar.Text = "&Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(636, 21);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(366, 332);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 387);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKosong);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.rdoTakeOut);
            this.Controls.Add(this.rdoEatIn);
            this.Controls.Add(this.grpTopping);
            this.Controls.Add(this.grpPinggiran);
            this.Controls.Add(this.grpUkuran);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza House";
            this.grpUkuran.ResumeLayout(false);
            this.grpUkuran.PerformLayout();
            this.grpPinggiran.ResumeLayout(false);
            this.grpPinggiran.PerformLayout();
            this.grpTopping.ResumeLayout(false);
            this.grpTopping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUkuran;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.GroupBox grpPinggiran;
        private System.Windows.Forms.RadioButton rdoNugget;
        private System.Windows.Forms.RadioButton rdoSosis;
        private System.Windows.Forms.RadioButton rdoKeju;
        private System.Windows.Forms.GroupBox grpTopping;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rdoEatIn;
        private System.Windows.Forms.RadioButton rdoTakeOut;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Button btnKosong;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblOutput;
    }
}

