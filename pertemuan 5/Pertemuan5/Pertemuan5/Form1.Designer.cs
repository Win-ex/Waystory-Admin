﻿namespace Pertemuan5
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
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.chkProcessor = new System.Windows.Forms.CheckBox();
            this.chkMouse = new System.Windows.Forms.CheckBox();
            this.chkKeyboard = new System.Windows.Forms.CheckBox();
            this.chkSpeaker = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(12, 12);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(157, 20);
            this.chkMonitor.TabIndex = 0;
            this.chkMonitor.Text = "Monitor (Rp1.000.000)";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkPrinter
            // 
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Location = new System.Drawing.Point(12, 38);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(141, 20);
            this.chkPrinter.TabIndex = 1;
            this.chkPrinter.Text = "Printer (Rp650.000)";
            this.chkPrinter.UseVisualStyleBackColor = true;
            this.chkPrinter.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkProcessor
            // 
            this.chkProcessor.AutoSize = true;
            this.chkProcessor.Location = new System.Drawing.Point(12, 64);
            this.chkProcessor.Name = "chkProcessor";
            this.chkProcessor.Size = new System.Drawing.Size(165, 20);
            this.chkProcessor.TabIndex = 2;
            this.chkProcessor.Text = "Processor (Rp800.000)";
            this.chkProcessor.UseVisualStyleBackColor = true;
            this.chkProcessor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkMouse
            // 
            this.chkMouse.AutoSize = true;
            this.chkMouse.Location = new System.Drawing.Point(12, 90);
            this.chkMouse.Name = "chkMouse";
            this.chkMouse.Size = new System.Drawing.Size(137, 20);
            this.chkMouse.TabIndex = 3;
            this.chkMouse.Text = "Mouse (Rp70.000)";
            this.chkMouse.UseVisualStyleBackColor = true;
            this.chkMouse.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkKeyboard
            // 
            this.chkKeyboard.AutoSize = true;
            this.chkKeyboard.Location = new System.Drawing.Point(12, 116);
            this.chkKeyboard.Name = "chkKeyboard";
            this.chkKeyboard.Size = new System.Drawing.Size(155, 20);
            this.chkKeyboard.TabIndex = 4;
            this.chkKeyboard.Text = "Keyboard (Rp80.000)";
            this.chkKeyboard.UseVisualStyleBackColor = true;
            this.chkKeyboard.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkSpeaker
            // 
            this.chkSpeaker.AutoSize = true;
            this.chkSpeaker.Location = new System.Drawing.Point(12, 142);
            this.chkSpeaker.Name = "chkSpeaker";
            this.chkSpeaker.Size = new System.Drawing.Size(148, 20);
            this.chkSpeaker.TabIndex = 5;
            this.chkSpeaker.Text = "Speaker (Rp50.000)";
            this.chkSpeaker.UseVisualStyleBackColor = true;
            this.chkSpeaker.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Pemesanan Paket Komputer :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(253, 174);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(208, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "{ total }";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 210);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSpeaker);
            this.Controls.Add(this.chkKeyboard);
            this.Controls.Add(this.chkMouse);
            this.Controls.Add(this.chkProcessor);
            this.Controls.Add(this.chkPrinter);
            this.Controls.Add(this.chkMonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkProcessor;
        private System.Windows.Forms.CheckBox chkMouse;
        private System.Windows.Forms.CheckBox chkKeyboard;
        private System.Windows.Forms.CheckBox chkSpeaker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}

