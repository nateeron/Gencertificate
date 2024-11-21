namespace Gencertificate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Gencer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CommonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Organization = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ServiceProvider = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Bitlength = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ExpiryDate = new System.Windows.Forms.TextBox();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BT_SetPath = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.txct_Ountput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_OpenPath = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ck_NewKey = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BT_Gencer
            // 
            this.BT_Gencer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Gencer.BackColor = System.Drawing.Color.SteelBlue;
            this.BT_Gencer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BT_Gencer.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Gencer.Location = new System.Drawing.Point(626, 237);
            this.BT_Gencer.Name = "BT_Gencer";
            this.BT_Gencer.Size = new System.Drawing.Size(125, 47);
            this.BT_Gencer.TabIndex = 19;
            this.BT_Gencer.Text = "Create";
            this.BT_Gencer.UseVisualStyleBackColor = false;
            this.BT_Gencer.Click += new System.EventHandler(this.BT_Gencer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Common Name :";
            // 
            // txt_CommonName
            // 
            this.txt_CommonName.Location = new System.Drawing.Point(132, 124);
            this.txt_CommonName.Name = "txt_CommonName";
            this.txt_CommonName.Size = new System.Drawing.Size(262, 23);
            this.txt_CommonName.TabIndex = 8;
            this.txt_CommonName.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organization :";
            // 
            // txt_Organization
            // 
            this.txt_Organization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Organization.Location = new System.Drawing.Point(489, 124);
            this.txt_Organization.Name = "txt_Organization";
            this.txt_Organization.Size = new System.Drawing.Size(262, 23);
            this.txt_Organization.TabIndex = 9;
            this.txt_Organization.Text = "ADi Digi Co., Ltd.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "OU :";
            // 
            // txt_OU
            // 
            this.txt_OU.Location = new System.Drawing.Point(132, 153);
            this.txt_OU.Name = "txt_OU";
            this.txt_OU.Size = new System.Drawing.Size(262, 23);
            this.txt_OU.TabIndex = 10;
            this.txt_OU.Text = "Information Technilogy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "City :";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(132, 182);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(262, 23);
            this.txt_City.TabIndex = 12;
            this.txt_City.Text = "Bangkok";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "State :";
            // 
            // txt_State
            // 
            this.txt_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_State.Location = new System.Drawing.Point(489, 182);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(262, 23);
            this.txt_State.TabIndex = 13;
            this.txt_State.Text = "Bangkok";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Country :";
            // 
            // txt_Country
            // 
            this.txt_Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Country.Location = new System.Drawing.Point(489, 211);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(262, 23);
            this.txt_Country.TabIndex = 15;
            this.txt_Country.Text = "TH";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "E-mail :";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.Location = new System.Drawing.Point(489, 153);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(262, 23);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.Text = "cto@adidigi.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Service Provider :";
            // 
            // txt_ServiceProvider
            // 
            this.txt_ServiceProvider.Location = new System.Drawing.Point(132, 211);
            this.txt_ServiceProvider.Name = "txt_ServiceProvider";
            this.txt_ServiceProvider.Size = new System.Drawing.Size(262, 23);
            this.txt_ServiceProvider.TabIndex = 14;
            this.txt_ServiceProvider.Text = "Microsoft RSA";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bit length :";
            // 
            // txt_Bitlength
            // 
            this.txt_Bitlength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bitlength.Location = new System.Drawing.Point(489, 82);
            this.txt_Bitlength.Name = "txt_Bitlength";
            this.txt_Bitlength.Size = new System.Drawing.Size(262, 23);
            this.txt_Bitlength.TabIndex = 7;
            this.txt_Bitlength.Text = "2048";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.Location = new System.Drawing.Point(489, 53);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(262, 23);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.Text = "123qwe";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Password :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Expiry Date :";
            // 
            // txt_ExpiryDate
            // 
            this.txt_ExpiryDate.Location = new System.Drawing.Point(132, 82);
            this.txt_ExpiryDate.Name = "txt_ExpiryDate";
            this.txt_ExpiryDate.Size = new System.Drawing.Size(262, 23);
            this.txt_ExpiryDate.TabIndex = 6;
            this.txt_ExpiryDate.Text = "365";
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(195, 53);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(199, 23);
            this.txt_filename.TabIndex = 4;
            this.txt_filename.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "File Certificate Name .pfx :";
            // 
            // BT_SetPath
            // 
            this.BT_SetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SetPath.Location = new System.Drawing.Point(676, 11);
            this.BT_SetPath.Name = "BT_SetPath";
            this.BT_SetPath.Size = new System.Drawing.Size(75, 23);
            this.BT_SetPath.TabIndex = 3;
            this.BT_SetPath.Text = "Path";
            this.BT_SetPath.UseVisualStyleBackColor = true;
            this.BT_SetPath.Click += new System.EventHandler(this.BT_SetPath_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.Location = new System.Drawing.Point(94, 11);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(576, 23);
            this.txt_Path.TabIndex = 2;
            // 
            // txct_Ountput
            // 
            this.txct_Ountput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txct_Ountput.Location = new System.Drawing.Point(12, 290);
            this.txct_Ountput.Name = "txct_Ountput";
            this.txct_Ountput.Size = new System.Drawing.Size(741, 283);
            this.txct_Ountput.TabIndex = 20;
            this.txct_Ountput.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(676, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_OpenPath
            // 
            this.BT_OpenPath.Location = new System.Drawing.Point(12, 10);
            this.BT_OpenPath.Name = "BT_OpenPath";
            this.BT_OpenPath.Size = new System.Drawing.Size(75, 23);
            this.BT_OpenPath.TabIndex = 1;
            this.BT_OpenPath.Text = "Open";
            this.BT_OpenPath.UseVisualStyleBackColor = true;
            this.BT_OpenPath.Click += new System.EventHandler(this.BT_OpenPath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Set Host";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Check install Cer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ck_NewKey
            // 
            this.ck_NewKey.AutoSize = true;
            this.ck_NewKey.BackColor = System.Drawing.Color.LightSalmon;
            this.ck_NewKey.Checked = true;
            this.ck_NewKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_NewKey.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ck_NewKey.ForeColor = System.Drawing.Color.Sienna;
            this.ck_NewKey.Location = new System.Drawing.Point(536, 246);
            this.ck_NewKey.Name = "ck_NewKey";
            this.ck_NewKey.Padding = new System.Windows.Forms.Padding(5);
            this.ck_NewKey.Size = new System.Drawing.Size(84, 29);
            this.ck_NewKey.TabIndex = 18;
            this.ck_NewKey.Text = "New Key";
            this.ck_NewKey.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(767, 618);
            this.Controls.Add(this.ck_NewKey);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BT_OpenPath);
            this.Controls.Add(this.txct_Ountput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.txt_ExpiryDate);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Bitlength);
            this.Controls.Add(this.txt_ServiceProvider);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_State);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_OU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Organization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CommonName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_SetPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_Gencer);
            this.Name = "Form1";
            this.Text = "GenCertificate V. 1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Gencer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CommonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Organization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ServiceProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Bitlength;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ExpiryDate;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BT_SetPath;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.RichTextBox txt_Output;
        private System.Windows.Forms.RichTextBox txct_Ountput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_OpenPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ck_NewKey;
    }
}
