﻿namespace Temperature_Forms
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
            this.rtbIncomingData = new System.Windows.Forms.RichTextBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.btnData = new System.Windows.Forms.Button();
            this.tbPorts = new System.Windows.Forms.TextBox();
            this.tbDataBits = new System.Windows.Forms.TextBox();
            this.tbStopBits = new System.Windows.Forms.TextBox();
            this.tbParity = new System.Windows.Forms.TextBox();
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbIncomingData
            // 
            this.rtbIncomingData.Location = new System.Drawing.Point(27, 286);
            this.rtbIncomingData.Name = "rtbIncomingData";
            this.rtbIncomingData.ShowSelectionMargin = true;
            this.rtbIncomingData.Size = new System.Drawing.Size(743, 312);
            this.rtbIncomingData.TabIndex = 9;
            this.rtbIncomingData.Text = "";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(329, 27);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(370, 28);
            this.cbPorts.TabIndex = 10;
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(329, 151);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(370, 28);
            this.cbStopBits.TabIndex = 11;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(329, 112);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(370, 28);
            this.cbParity.TabIndex = 12;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(329, 70);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(370, 28);
            this.cbBaudRate.TabIndex = 13;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(329, 195);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(370, 28);
            this.cbDataBits.TabIndex = 14;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(216, 240);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(78, 31);
            this.btnData.TabIndex = 15;
            this.btnData.Text = "RUN";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnDataClick);
            // 
            // tbPorts
            // 
            this.tbPorts.Enabled = false;
            this.tbPorts.Location = new System.Drawing.Point(27, 27);
            this.tbPorts.Name = "tbPorts";
            this.tbPorts.Size = new System.Drawing.Size(123, 26);
            this.tbPorts.TabIndex = 16;
            this.tbPorts.Text = "Ports";
            this.tbPorts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDataBits
            // 
            this.tbDataBits.Enabled = false;
            this.tbDataBits.Location = new System.Drawing.Point(27, 195);
            this.tbDataBits.Name = "tbDataBits";
            this.tbDataBits.Size = new System.Drawing.Size(123, 26);
            this.tbDataBits.TabIndex = 17;
            this.tbDataBits.Text = "DataBits";
            this.tbDataBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStopBits
            // 
            this.tbStopBits.Enabled = false;
            this.tbStopBits.Location = new System.Drawing.Point(27, 153);
            this.tbStopBits.Name = "tbStopBits";
            this.tbStopBits.Size = new System.Drawing.Size(123, 26);
            this.tbStopBits.TabIndex = 18;
            this.tbStopBits.Text = "StopBits";
            this.tbStopBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbParity
            // 
            this.tbParity.Enabled = false;
            this.tbParity.Location = new System.Drawing.Point(27, 112);
            this.tbParity.Name = "tbParity";
            this.tbParity.Size = new System.Drawing.Size(123, 26);
            this.tbParity.TabIndex = 19;
            this.tbParity.Text = "Parity";
            this.tbParity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Enabled = false;
            this.tbBaudRate.Location = new System.Drawing.Point(27, 70);
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(123, 26);
            this.tbBaudRate.TabIndex = 20;
            this.tbBaudRate.Text = "BaudRate";
            this.tbBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(816, 639);
            this.Controls.Add(this.tbBaudRate);
            this.Controls.Add(this.tbParity);
            this.Controls.Add(this.tbStopBits);
            this.Controls.Add(this.tbDataBits);
            this.Controls.Add(this.tbPorts);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.rtbIncomingData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbIncomingData;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.TextBox tbPorts;
        private System.Windows.Forms.TextBox tbDataBits;
        private System.Windows.Forms.TextBox tbStopBits;
        private System.Windows.Forms.TextBox tbParity;
        private System.Windows.Forms.TextBox tbBaudRate;
    }
}

