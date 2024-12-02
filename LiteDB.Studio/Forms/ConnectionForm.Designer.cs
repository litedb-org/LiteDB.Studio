namespace LiteDB.Studio.Forms
{
    partial class ConnectionForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxConnectionMode = new System.Windows.Forms.GroupBox();
            this.radModeShared = new System.Windows.Forms.RadioButton();
            this.radModeDirect = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtInitialSize = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCulture = new System.Windows.Forms.ComboBox();
            this.chkUpgrade = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkReadonly = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuildDefaultFileName = new System.Windows.Forms.Button();
            this.groupBoxConnectionMode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnectionMode
            // 
            this.groupBoxConnectionMode.Controls.Add(this.radModeShared);
            this.groupBoxConnectionMode.Controls.Add(this.radModeDirect);
            this.groupBoxConnectionMode.Location = new System.Drawing.Point(12, 11);
            this.groupBoxConnectionMode.Name = "groupBoxConnectionMode";
            this.groupBoxConnectionMode.Size = new System.Drawing.Size(569, 60);
            this.groupBoxConnectionMode.TabIndex = 27;
            this.groupBoxConnectionMode.TabStop = false;
            this.groupBoxConnectionMode.Text = "Connection Mode";
            // 
            // radModeShared
            // 
            this.radModeShared.AutoSize = true;
            this.radModeShared.Location = new System.Drawing.Point(151, 25);
            this.radModeShared.Name = "radModeShared";
            this.radModeShared.Size = new System.Drawing.Size(92, 29);
            this.radModeShared.TabIndex = 10;
            this.radModeShared.Text = "Shared";
            this.radModeShared.UseVisualStyleBackColor = true;
            // 
            // radModeDirect
            // 
            this.radModeDirect.AutoSize = true;
            this.radModeDirect.Checked = true;
            this.radModeDirect.Location = new System.Drawing.Point(30, 25);
            this.radModeDirect.Name = "radModeDirect";
            this.radModeDirect.Size = new System.Drawing.Size(83, 29);
            this.radModeDirect.TabIndex = 9;
            this.radModeDirect.TabStop = true;
            this.radModeDirect.Text = "Direct";
            this.radModeDirect.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = global::LiteDB.Studio.Properties.Resources.database_connect;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(454, 383);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOK.Size = new System.Drawing.Size(127, 38);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Connect";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::LiteDB.Studio.Properties.Resources.folder_explore;
            this.btnOpen.Location = new System.Drawing.Point(527, 28);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(28, 24);
            this.btnOpen.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnOpen, "Open existing datafile");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // txtInitialSize
            // 
            this.txtInitialSize.Location = new System.Drawing.Point(151, 61);
            this.txtInitialSize.Name = "txtInitialSize";
            this.txtInitialSize.Size = new System.Drawing.Size(70, 31);
            this.txtInitialSize.TabIndex = 24;
            this.txtInitialSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBuildDefaultFileName);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.txtFilename);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 72);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filename";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(19, 28);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(502, 31);
            this.txtFilename.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbSort);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbCulture);
            this.groupBox3.Controls.Add(this.chkUpgrade);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtInitialSize);
            this.groupBox3.Controls.Add(this.chkReadonly);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 209);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "/";
            // 
            // cmbSort
            // 
            this.cmbSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(292, 100);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(117, 33);
            this.cmbSort.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Collation:";
            // 
            // cmbCulture
            // 
            this.cmbCulture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCulture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCulture.FormattingEnabled = true;
            this.cmbCulture.Location = new System.Drawing.Point(151, 100);
            this.cmbCulture.Name = "cmbCulture";
            this.cmbCulture.Size = new System.Drawing.Size(117, 33);
            this.cmbCulture.TabIndex = 35;
            // 
            // chkUpgrade
            // 
            this.chkUpgrade.AutoSize = true;
            this.chkUpgrade.Location = new System.Drawing.Point(21, 175);
            this.chkUpgrade.Name = "chkUpgrade";
            this.chkUpgrade.Size = new System.Drawing.Size(319, 29);
            this.chkUpgrade.TabIndex = 33;
            this.chkUpgrade.Text = "Upgrade from LiteDB v4 (if needed)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(404, 31);
            this.txtPassword.TabIndex = 4;
            // 
            // chkReadonly
            // 
            this.chkReadonly.AutoSize = true;
            this.chkReadonly.Location = new System.Drawing.Point(21, 139);
            this.chkReadonly.Name = "chkReadonly";
            this.chkReadonly.Size = new System.Drawing.Size(116, 29);
            this.chkReadonly.TabIndex = 27;
            this.chkReadonly.Text = "Read only";
            this.chkReadonly.UseVisualStyleBackColor = true;
            this.chkReadonly.CheckedChanged += new System.EventHandler(this.chkReadonly_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Initial Size (MB):";
            // 
            // buttonBuildDefaultFileName
            // 
            this.buttonBuildDefaultFileName.Location = new System.Drawing.Point(318, 0);
            this.buttonBuildDefaultFileName.Name = "buttonBuildDefaultFileName";
            this.buttonBuildDefaultFileName.Size = new System.Drawing.Size(203, 23);
            this.buttonBuildDefaultFileName.TabIndex = 4;
            this.buttonBuildDefaultFileName.Text = "Build Default File Name";
            this.buttonBuildDefaultFileName.UseVisualStyleBackColor = true;
            this.buttonBuildDefaultFileName.Click += new System.EventHandler(this.buttonBuildDefaultFileName_Click);
            // 
            // ConnectionForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxConnectionMode);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Manager";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ConnectionForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ConnectionForm_DragEnter);
            this.groupBoxConnectionMode.ResumeLayout(false);
            this.groupBoxConnectionMode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxConnectionMode;
        private System.Windows.Forms.RadioButton radModeDirect;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInitialSize;
        private System.Windows.Forms.CheckBox chkReadonly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkUpgrade;
        private System.Windows.Forms.RadioButton radModeShared;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCulture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBuildDefaultFileName;
    }
}
