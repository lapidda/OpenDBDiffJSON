using System.ComponentModel;
using System.Windows.Forms;

namespace OpenDBDiff.SqlServer.Ui
{
    partial class SqlServerConnectFront
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboServer = new ComboBox();
            cboAuthentication = new ComboBox();
            label5 = new Label();
            cboDatabase = new ComboBox();
            label6 = new Label();
            txtUsername = new TextBox();
            btnTest = new Button();
            lblName = new Label();
            gradientPanel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnJSONExport = new Button();
            btnJSONImport = new Button();
            lblJSONPath = new Label();
            textBox1 = new TextBox();
            gradientPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(109, 165);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(239, 27);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 20);
            label4.TabIndex = 16;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 20);
            label3.TabIndex = 15;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 20);
            label2.TabIndex = 14;
            label2.Text = "Server Host:";
            // 
            // cboServer
            // 
            cboServer.FormattingEnabled = true;
            cboServer.Items.AddRange(new object[] { "(local)" });
            cboServer.Location = new System.Drawing.Point(109, 43);
            cboServer.Margin = new Padding(4, 5, 4, 5);
            cboServer.Name = "cboServer";
            cboServer.Size = new System.Drawing.Size(239, 28);
            cboServer.TabIndex = 0;
            cboServer.DropDown += cboServer_DropDown;
            cboServer.SelectedIndexChanged += cboServer_SelectedIndexChanged;
            cboServer.TextChanged += cboServer_TextChanged;
            // 
            // cboAuthentication
            // 
            cboAuthentication.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAuthentication.FormattingEnabled = true;
            cboAuthentication.Items.AddRange(new object[] { "Windows Authentication", "SQL Server Authentication" });
            cboAuthentication.Location = new System.Drawing.Point(109, 85);
            cboAuthentication.Margin = new Padding(4, 5, 4, 5);
            cboAuthentication.Name = "cboAuthentication";
            cboAuthentication.Size = new System.Drawing.Size(239, 28);
            cboAuthentication.TabIndex = 1;
            cboAuthentication.SelectedIndexChanged += cboAuthentication_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(4, 89);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 20);
            label5.TabIndex = 20;
            label5.Text = "Authentication";
            // 
            // cboDatabase
            // 
            cboDatabase.FormattingEnabled = true;
            cboDatabase.Location = new System.Drawing.Point(109, 205);
            cboDatabase.Margin = new Padding(4, 5, 4, 5);
            cboDatabase.Name = "cboDatabase";
            cboDatabase.Size = new System.Drawing.Size(296, 28);
            cboDatabase.TabIndex = 4;
            cboDatabase.DropDown += cboDatabase_DropDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 209);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 20);
            label6.TabIndex = 23;
            label6.Text = "Database:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(109, 125);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(239, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTest.FlatStyle = FlatStyle.System;
            btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTest.Location = new System.Drawing.Point(384, 37);
            btnTest.Margin = new Padding(4, 5, 4, 5);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(124, 43);
            btnTest.TabIndex = 5;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblName.Location = new System.Drawing.Point(23, 8);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(133, 17);
            lblName.TabIndex = 24;
            lblName.Text = "Source Database";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(lblName);
            gradientPanel1.Location = new System.Drawing.Point(0, 0);
            gradientPanel1.Margin = new Padding(4, 5, 4, 5);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new System.Drawing.Size(512, 37);
            gradientPanel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.database_yellow;
            pictureBox1.Location = new System.Drawing.Point(3, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(20, 28);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnJSONExport
            // 
            btnJSONExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnJSONExport.FlatStyle = FlatStyle.System;
            btnJSONExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJSONExport.Location = new System.Drawing.Point(436, 173);
            btnJSONExport.Margin = new Padding(4, 5, 4, 5);
            btnJSONExport.Name = "btnJSONExport";
            btnJSONExport.Size = new System.Drawing.Size(72, 43);
            btnJSONExport.TabIndex = 27;
            btnJSONExport.Text = "JSON Export";
            btnJSONExport.UseVisualStyleBackColor = true;
            btnJSONExport.Click += btnJSONExport_Click;
            // 
            // btnJSONImport
            // 
            btnJSONImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnJSONImport.FlatStyle = FlatStyle.System;
            btnJSONImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnJSONImport.Location = new System.Drawing.Point(436, 226);
            btnJSONImport.Margin = new Padding(4, 5, 4, 5);
            btnJSONImport.Name = "btnJSONImport";
            btnJSONImport.Size = new System.Drawing.Size(72, 43);
            btnJSONImport.TabIndex = 28;
            btnJSONImport.Text = "JSON Import";
            btnJSONImport.UseVisualStyleBackColor = true;
            // 
            // lblJSONPath
            // 
            lblJSONPath.AutoSize = true;
            lblJSONPath.Location = new System.Drawing.Point(4, 245);
            lblJSONPath.Margin = new Padding(4, 0, 4, 0);
            lblJSONPath.Name = "lblJSONPath";
            lblJSONPath.Size = new System.Drawing.Size(79, 20);
            lblJSONPath.TabIndex = 29;
            lblJSONPath.Text = "JSON Path:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(109, 242);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(296, 27);
            textBox1.TabIndex = 30;
            // 
            // SqlServerConnectFront
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(textBox1);
            Controls.Add(lblJSONPath);
            Controls.Add(btnJSONImport);
            Controls.Add(btnJSONExport);
            Controls.Add(gradientPanel1);
            Controls.Add(cboDatabase);
            Controls.Add(label6);
            Controls.Add(btnTest);
            Controls.Add(cboAuthentication);
            Controls.Add(label5);
            Controls.Add(cboServer);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SqlServerConnectFront";
            Size = new System.Drawing.Size(512, 282);
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboServer;
        private ComboBox cboAuthentication;
        private Label label5;
        private Button btnTest;
        private ComboBox cboDatabase;
        private Label label6;
        private Label lblName;
        private Panel gradientPanel1;
        private PictureBox pictureBox1;
        private Button btnJSONExport;
        private Button btnJSONImport;
        private Label lblJSONPath;
        private TextBox textBox1;
    }
}
