namespace SerialMonitor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Terminal = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nudMessage = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.Opcje = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Terminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessage)).BeginInit();
            this.Opcje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Terminal);
            this.tabControl1.Controls.Add(this.Opcje);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // Terminal
            // 
            this.Terminal.Controls.Add(this.richTextBox1);
            this.Terminal.Controls.Add(this.pictureBox);
            this.Terminal.Controls.Add(this.nudMessage);
            this.Terminal.Controls.Add(this.btnClear);
            this.Terminal.Controls.Add(this.btnSend);
            this.Terminal.Controls.Add(this.labelConnection);
            this.Terminal.Controls.Add(this.labelLog);
            this.Terminal.Location = new System.Drawing.Point(4, 29);
            this.Terminal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Terminal.Name = "Terminal";
            this.Terminal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Terminal.Size = new System.Drawing.Size(511, 527);
            this.Terminal.TabIndex = 0;
            this.Terminal.Text = "Terminal";
            this.Terminal.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(470, 382);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Red;
            this.pictureBox.Location = new System.Drawing.Point(24, 488);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(25, 24);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // nudMessage
            // 
            this.nudMessage.Hexadecimal = true;
            this.nudMessage.Location = new System.Drawing.Point(24, 441);
            this.nudMessage.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMessage.Name = "nudMessage";
            this.nudMessage.Size = new System.Drawing.Size(135, 26);
            this.nudMessage.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(347, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(178, 437);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(146, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(75, 488);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(123, 20);
            this.labelConnection.TabIndex = 1;
            this.labelConnection.Text = "Brak połączenia";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(20, 15);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(40, 20);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Log:";
            // 
            // Opcje
            // 
            this.Opcje.Controls.Add(this.btnCancel);
            this.Opcje.Controls.Add(this.btnRefresh);
            this.Opcje.Controls.Add(this.btnDefault);
            this.Opcje.Controls.Add(this.cbStopBits);
            this.Opcje.Controls.Add(this.cbParityBits);
            this.Opcje.Controls.Add(this.cbDataBits);
            this.Opcje.Controls.Add(this.cbBaud);
            this.Opcje.Controls.Add(this.cbName);
            this.Opcje.Controls.Add(this.label5);
            this.Opcje.Controls.Add(this.label4);
            this.Opcje.Controls.Add(this.label3);
            this.Opcje.Controls.Add(this.label2);
            this.Opcje.Controls.Add(this.label1);
            this.Opcje.Location = new System.Drawing.Point(4, 29);
            this.Opcje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Opcje.Name = "Opcje";
            this.Opcje.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Opcje.Size = new System.Drawing.Size(511, 527);
            this.Opcje.TabIndex = 1;
            this.Opcje.Text = "Opcje";
            this.Opcje.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(205, 459);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 37);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(79, 459);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(119, 37);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Domyślne";
            this.btnDefault.UseVisualStyleBackColor = true;
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(328, 379);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 28);
            this.cbStopBits.TabIndex = 9;
            // 
            // cbParityBits
            // 
            this.cbParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Location = new System.Drawing.Point(328, 296);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(121, 28);
            this.cbParityBits.TabIndex = 8;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbDataBits.Location = new System.Drawing.Point(328, 213);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 28);
            this.cbDataBits.TabIndex = 7;
            // 
            // cbBaud
            // 
            this.cbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbBaud.Location = new System.Drawing.Point(328, 130);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 28);
            this.cbBaud.TabIndex = 6;
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(328, 47);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 28);
            this.cbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bity stopu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bity przystości:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bity danych:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prędkość:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa portu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 560);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SerialMonitor";
            this.tabControl1.ResumeLayout(false);
            this.Terminal.ResumeLayout(false);
            this.Terminal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessage)).EndInit();
            this.Opcje.ResumeLayout(false);
            this.Opcje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Terminal;
        private System.Windows.Forms.TabPage Opcje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown nudMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelLog;
    }
}

