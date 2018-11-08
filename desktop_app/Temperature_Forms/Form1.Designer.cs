namespace Temperature_Forms
{
    partial class TemperatureReadingForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbIncomingData
            // 
            this.rtbIncomingData.Enabled = false;
            this.rtbIncomingData.Location = new System.Drawing.Point(27, 361);
            this.rtbIncomingData.Name = "rtbIncomingData";
            this.rtbIncomingData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbIncomingData.ShowSelectionMargin = true;
            this.rtbIncomingData.Size = new System.Drawing.Size(791, 329);
            this.rtbIncomingData.TabIndex = 9;
            this.rtbIncomingData.Text = "";
            this.rtbIncomingData.WordWrap = false;
            this.rtbIncomingData.TextChanged += new System.EventHandler(this.rtbIncomingData_TextChanged);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(401, 27);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(370, 28);
            this.cbPorts.TabIndex = 10;
            this.cbPorts.Text = "COM3";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(401, 153);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(370, 28);
            this.cbStopBits.TabIndex = 11;
            this.cbStopBits.Text = "One";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(401, 112);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(370, 28);
            this.cbParity.TabIndex = 12;
            this.cbParity.Text = "None";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(401, 70);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(370, 28);
            this.cbBaudRate.TabIndex = 13;
            this.cbBaudRate.Text = "115200";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(401, 195);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(370, 28);
            this.cbDataBits.TabIndex = 14;
            this.cbDataBits.Text = "8";
            // 
            // btnData
            // 
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnData.Location = new System.Drawing.Point(401, 253);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(142, 43);
            this.btnData.TabIndex = 15;
            this.btnData.Text = "Receive Data";
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
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(27, 253);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(99, 43);
            this.btnOpen.TabIndex = 21;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(147, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 43);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressBar.Location = new System.Drawing.Point(27, 314);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(791, 30);
            this.progressBar.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(645, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 43);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TemperatureReadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(850, 717);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
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
            this.Name = "TemperatureReadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Measure";
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
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnClear;
    }
}

