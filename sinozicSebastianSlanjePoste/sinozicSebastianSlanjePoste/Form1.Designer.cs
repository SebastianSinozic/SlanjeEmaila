namespace sinozicSebastianSlanjePoste
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
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(171, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.chkSSL);
            this.Setting.Controls.Add(this.txtSmtp);
            this.Setting.Controls.Add(this.label7);
            this.Setting.Controls.Add(this.txtPort);
            this.Setting.Controls.Add(this.txtPassword);
            this.Setting.Controls.Add(this.label8);
            this.Setting.Controls.Add(this.btnSend);
            this.Setting.Controls.Add(this.label5);
            this.Setting.Controls.Add(this.txtUsername);
            this.Setting.Controls.Add(this.label6);
            this.Setting.Location = new System.Drawing.Point(91, 210);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(343, 100);
            this.Setting.TabIndex = 2;
            this.Setting.TabStop = false;
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Location = new System.Drawing.Point(171, 22);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(46, 17);
            this.chkSSL.TabIndex = 16;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(171, 74);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(151, 20);
            this.txtSmtp.TabIndex = 15;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Smtp:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(71, 74);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(54, 20);
            this.txtPort.TabIndex = 14;
            this.txtPort.Text = "587";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(93, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(71, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(93, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(91, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(343, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(91, 43);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(343, 20);
            this.txtCC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CC:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(91, 119);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(343, 77);
            this.txtMessage.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(91, 79);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(343, 20);
            this.txtSubject.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 334);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Send mail";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
    }
}

