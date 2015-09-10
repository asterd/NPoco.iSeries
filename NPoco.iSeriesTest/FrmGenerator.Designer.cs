namespace NPoco.iSeriesTest
{
    partial class FrmGenerator
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
            this.separator1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.txtDBUser = new System.Windows.Forms.TextBox();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.chkSqlSchema = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.orientableLabel3 = new NPoco.iSeriesTest.Components.OrientableLabel();
            this.orientableLabel2 = new NPoco.iSeriesTest.Components.OrientableLabel();
            this.orientableLabel1 = new NPoco.iSeriesTest.Components.OrientableLabel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // separator1
            // 
            this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(6, 49);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(541, 1);
            this.separator1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# Poco generator per iSeries";
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(63, 91);
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.Size = new System.Drawing.Size(143, 20);
            this.txtDBServer.TabIndex = 1;
            // 
            // txtDBUser
            // 
            this.txtDBUser.Location = new System.Drawing.Point(225, 91);
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Size = new System.Drawing.Size(143, 20);
            this.txtDBUser.TabIndex = 2;
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(388, 91);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.Size = new System.Drawing.Size(143, 20);
            this.txtDBPassword.TabIndex = 3;
            this.txtDBPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SERVER URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "UTENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PASSWORD";
            // 
            // txtLib
            // 
            this.txtLib.Location = new System.Drawing.Point(63, 172);
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(143, 20);
            this.txtLib.TabIndex = 4;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(225, 172);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(143, 20);
            this.txtTable.TabIndex = 5;
            // 
            // chkSqlSchema
            // 
            this.chkSqlSchema.AutoSize = true;
            this.chkSqlSchema.Location = new System.Drawing.Point(391, 172);
            this.chkSqlSchema.Name = "chkSqlSchema";
            this.chkSqlSchema.Size = new System.Drawing.Size(95, 17);
            this.chkSqlSchema.TabIndex = 6;
            this.chkSqlSchema.Text = "SQL SCHEMA";
            this.chkSqlSchema.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "LIBRERIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "TABELLA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "NAMESPACE DEFAULT:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(225, 246);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(306, 20);
            this.txtNamespace.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "CARTELLA DESTINAZIONE:";
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Location = new System.Drawing.Point(225, 272);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(276, 20);
            this.txtDestFolder.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(411, 318);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 45);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Genera Poco";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // orientableLabel3
            // 
            this.orientableLabel3.BackColor = System.Drawing.Color.OrangeRed;
            this.orientableLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientableLabel3.ForeColor = System.Drawing.Color.White;
            this.orientableLabel3.Location = new System.Drawing.Point(7, 230);
            this.orientableLabel3.Name = "orientableLabel3";
            this.orientableLabel3.RotationAngle = -90D;
            this.orientableLabel3.Size = new System.Drawing.Size(32, 76);
            this.orientableLabel3.TabIndex = 19;
            this.orientableLabel3.Text = "OPZIONI";
            this.orientableLabel3.TextDirection = NPoco.iSeriesTest.Components.Direction.Clockwise;
            this.orientableLabel3.TextOrientation = NPoco.iSeriesTest.Components.Orientation.Rotate;
            // 
            // orientableLabel2
            // 
            this.orientableLabel2.BackColor = System.Drawing.Color.DarkOrange;
            this.orientableLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientableLabel2.ForeColor = System.Drawing.Color.White;
            this.orientableLabel2.Location = new System.Drawing.Point(7, 144);
            this.orientableLabel2.Name = "orientableLabel2";
            this.orientableLabel2.RotationAngle = -90D;
            this.orientableLabel2.Size = new System.Drawing.Size(32, 76);
            this.orientableLabel2.TabIndex = 5;
            this.orientableLabel2.Text = "TABELLA";
            this.orientableLabel2.TextDirection = NPoco.iSeriesTest.Components.Direction.Clockwise;
            this.orientableLabel2.TextOrientation = NPoco.iSeriesTest.Components.Orientation.Rotate;
            // 
            // orientableLabel1
            // 
            this.orientableLabel1.BackColor = System.Drawing.Color.SteelBlue;
            this.orientableLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientableLabel1.ForeColor = System.Drawing.Color.White;
            this.orientableLabel1.Location = new System.Drawing.Point(7, 60);
            this.orientableLabel1.Name = "orientableLabel1";
            this.orientableLabel1.RotationAngle = -90D;
            this.orientableLabel1.Size = new System.Drawing.Size(32, 72);
            this.orientableLabel1.TabIndex = 3;
            this.orientableLabel1.Text = "AS400";
            this.orientableLabel1.TextDirection = NPoco.iSeriesTest.Components.Direction.Clockwise;
            this.orientableLabel1.TextOrientation = NPoco.iSeriesTest.Components.Orientation.Rotate;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(507, 271);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSelectFolder.TabIndex = 22;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // FrmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 375);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDestFolder);
            this.Controls.Add(this.orientableLabel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkSqlSchema);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.txtLib);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDBPassword);
            this.Controls.Add(this.txtDBUser);
            this.Controls.Add(this.txtDBServer);
            this.Controls.Add(this.orientableLabel2);
            this.Controls.Add(this.orientableLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genera POCO per Tabelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Label label1;
        private Components.OrientableLabel orientableLabel1;
        private Components.OrientableLabel orientableLabel2;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.TextBox txtDBUser;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.CheckBox chkSqlSchema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamespace;
        private Components.OrientableLabel orientableLabel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}