namespace ProjektWinForm.Settings
{

    partial class SettingsWinForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveLanguage_btn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cancelSettings_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileSettings_btn = new System.Windows.Forms.Button();
            this.pathTextSettings = new System.Windows.Forms.TextBox();
            this.SearchFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveStartMode_btn = new System.Windows.Forms.Button();
            this.advanced_rbn_settings = new System.Windows.Forms.RadioButton();
            this.regular_rbn_mode = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveLanguage_btn);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(193, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 60);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Language";
            // 
            // saveLanguage_btn
            // 
            this.saveLanguage_btn.Location = new System.Drawing.Point(157, 21);
            this.saveLanguage_btn.Name = "saveLanguage_btn";
            this.saveLanguage_btn.Size = new System.Drawing.Size(51, 24);
            this.saveLanguage_btn.TabIndex = 16;
            this.saveLanguage_btn.Text = "Save";
            this.saveLanguage_btn.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // cancelSettings_btn
            // 
            this.cancelSettings_btn.Location = new System.Drawing.Point(677, 390);
            this.cancelSettings_btn.Name = "cancelSettings_btn";
            this.cancelSettings_btn.Size = new System.Drawing.Size(114, 41);
            this.cancelSettings_btn.TabIndex = 19;
            this.cancelSettings_btn.Text = "Cancel";
            this.cancelSettings_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveFileSettings_btn);
            this.groupBox2.Controls.Add(this.pathTextSettings);
            this.groupBox2.Controls.Add(this.SearchFile);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 78);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // saveFileSettings_btn
            // 
            this.saveFileSettings_btn.Location = new System.Drawing.Point(710, 48);
            this.saveFileSettings_btn.Name = "saveFileSettings_btn";
            this.saveFileSettings_btn.Size = new System.Drawing.Size(75, 23);
            this.saveFileSettings_btn.TabIndex = 3;
            this.saveFileSettings_btn.Text = "Save";
            this.saveFileSettings_btn.UseVisualStyleBackColor = true;
            this.saveFileSettings_btn.Click += new System.EventHandler(this.saveFileSettings_btn_Click);
            // 
            // pathTextSettings
            // 
            this.pathTextSettings.Location = new System.Drawing.Point(3, 19);
            this.pathTextSettings.Multiline = true;
            this.pathTextSettings.Name = "pathTextSettings";
            this.pathTextSettings.ReadOnly = true;
            this.pathTextSettings.Size = new System.Drawing.Size(701, 20);
            this.pathTextSettings.TabIndex = 1;
            // 
            // SearchFile
            // 
            this.SearchFile.Location = new System.Drawing.Point(710, 19);
            this.SearchFile.Name = "SearchFile";
            this.SearchFile.Size = new System.Drawing.Size(75, 23);
            this.SearchFile.TabIndex = 2;
            this.SearchFile.Text = "Search";
            this.SearchFile.UseVisualStyleBackColor = true;
            this.SearchFile.Click += new System.EventHandler(this.SearchFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saveStartMode_btn);
            this.groupBox1.Controls.Add(this.advanced_rbn_settings);
            this.groupBox1.Controls.Add(this.regular_rbn_mode);
            this.groupBox1.Location = new System.Drawing.Point(9, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 73);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // saveStartMode_btn
            // 
            this.saveStartMode_btn.Location = new System.Drawing.Point(108, 24);
            this.saveStartMode_btn.Name = "saveStartMode_btn";
            this.saveStartMode_btn.Size = new System.Drawing.Size(51, 24);
            this.saveStartMode_btn.TabIndex = 17;
            this.saveStartMode_btn.Text = "Save";
            this.saveStartMode_btn.UseVisualStyleBackColor = true;
            this.saveStartMode_btn.Click += new System.EventHandler(this.saveStartMode_btn_Click);
            // 
            // advanced_rbn_settings
            // 
            this.advanced_rbn_settings.AutoSize = true;
            this.advanced_rbn_settings.Location = new System.Drawing.Point(6, 19);
            this.advanced_rbn_settings.Name = "advanced_rbn_settings";
            this.advanced_rbn_settings.Size = new System.Drawing.Size(74, 17);
            this.advanced_rbn_settings.TabIndex = 4;
            this.advanced_rbn_settings.TabStop = true;
            this.advanced_rbn_settings.Text = "Advanced";
            this.advanced_rbn_settings.UseVisualStyleBackColor = true;
            // 
            // regular_rbn_mode
            // 
            this.regular_rbn_mode.AutoSize = true;
            this.regular_rbn_mode.Location = new System.Drawing.Point(6, 37);
            this.regular_rbn_mode.Name = "regular_rbn_mode";
            this.regular_rbn_mode.Size = new System.Drawing.Size(62, 17);
            this.regular_rbn_mode.TabIndex = 5;
            this.regular_rbn_mode.TabStop = true;
            this.regular_rbn_mode.Text = "Regular";
            this.regular_rbn_mode.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Standart Mode = Regular";
            // 
            // SettingsWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelSettings_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsWinForm";
            this.Text = "SettingsWinForm";
            this.Load += new System.EventHandler(this.SettingsWinForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveLanguage_btn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button cancelSettings_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveFileSettings_btn;
        public System.Windows.Forms.TextBox pathTextSettings;
        private System.Windows.Forms.Button SearchFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveStartMode_btn;
        private System.Windows.Forms.RadioButton advanced_rbn_settings;
        private System.Windows.Forms.RadioButton regular_rbn_mode;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}