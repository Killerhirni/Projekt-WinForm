namespace ProjektWinForm.Application
{

    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.advancedManager_grpb = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showResults_btn = new System.Windows.Forms.Button();
            this.manageStrecke_btn = new System.Windows.Forms.Button();
            this.manageWettkampf_btn = new System.Windows.Forms.Button();
            this.manageTeilnahme_btn = new System.Windows.Forms.Button();
            this.manageFahrer_btn = new System.Windows.Forms.Button();
            this.manageTeam_btn = new System.Windows.Forms.Button();
            this.SettingTab = new System.Windows.Forms.TabPage();
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
            this.MaskInside = new System.Windows.Forms.TabPage();
            this.regular_rbn = new System.Windows.Forms.RadioButton();
            this.advanced_rbn = new System.Windows.Forms.RadioButton();
            this.openTable = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.SearchPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.advancedManager_grpb.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MaskInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(0, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Beta Release 0.0.0.1";
            // 
            // advancedManager_grpb
            // 
            this.advancedManager_grpb.Controls.Add(this.button1);
            this.advancedManager_grpb.Controls.Add(this.showResults_btn);
            this.advancedManager_grpb.Controls.Add(this.manageStrecke_btn);
            this.advancedManager_grpb.Controls.Add(this.manageWettkampf_btn);
            this.advancedManager_grpb.Controls.Add(this.manageTeilnahme_btn);
            this.advancedManager_grpb.Controls.Add(this.manageFahrer_btn);
            this.advancedManager_grpb.Controls.Add(this.manageTeam_btn);
            this.advancedManager_grpb.Location = new System.Drawing.Point(3, 12);
            this.advancedManager_grpb.Name = "advancedManager_grpb";
            this.advancedManager_grpb.Size = new System.Drawing.Size(162, 423);
            this.advancedManager_grpb.TabIndex = 13;
            this.advancedManager_grpb.TabStop = false;
            this.advancedManager_grpb.Text = "Advanced Manager";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(139, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 22);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showResults_btn
            // 
            this.showResults_btn.Location = new System.Drawing.Point(6, 360);
            this.showResults_btn.Name = "showResults_btn";
            this.showResults_btn.Size = new System.Drawing.Size(150, 57);
            this.showResults_btn.TabIndex = 5;
            this.showResults_btn.Text = "Show Results";
            this.showResults_btn.UseVisualStyleBackColor = true;
            // 
            // manageStrecke_btn
            // 
            this.manageStrecke_btn.Location = new System.Drawing.Point(7, 232);
            this.manageStrecke_btn.Name = "manageStrecke_btn";
            this.manageStrecke_btn.Size = new System.Drawing.Size(149, 45);
            this.manageStrecke_btn.TabIndex = 4;
            this.manageStrecke_btn.Text = "Manage Strecke";
            this.manageStrecke_btn.UseVisualStyleBackColor = true;
            // 
            // manageWettkampf_btn
            // 
            this.manageWettkampf_btn.Location = new System.Drawing.Point(7, 181);
            this.manageWettkampf_btn.Name = "manageWettkampf_btn";
            this.manageWettkampf_btn.Size = new System.Drawing.Size(149, 45);
            this.manageWettkampf_btn.TabIndex = 3;
            this.manageWettkampf_btn.Text = "Manage Wettkampf";
            this.manageWettkampf_btn.UseVisualStyleBackColor = true;
            // 
            // manageTeilnahme_btn
            // 
            this.manageTeilnahme_btn.Location = new System.Drawing.Point(7, 130);
            this.manageTeilnahme_btn.Name = "manageTeilnahme_btn";
            this.manageTeilnahme_btn.Size = new System.Drawing.Size(149, 45);
            this.manageTeilnahme_btn.TabIndex = 2;
            this.manageTeilnahme_btn.Text = "Manage Teilnahme";
            this.manageTeilnahme_btn.UseVisualStyleBackColor = true;
            // 
            // manageFahrer_btn
            // 
            this.manageFahrer_btn.Location = new System.Drawing.Point(7, 79);
            this.manageFahrer_btn.Name = "manageFahrer_btn";
            this.manageFahrer_btn.Size = new System.Drawing.Size(149, 45);
            this.manageFahrer_btn.TabIndex = 1;
            this.manageFahrer_btn.Text = "Manage Fahrer";
            this.manageFahrer_btn.UseVisualStyleBackColor = true;
            // 
            // manageTeam_btn
            // 
            this.manageTeam_btn.Location = new System.Drawing.Point(7, 27);
            this.manageTeam_btn.Name = "manageTeam_btn";
            this.manageTeam_btn.Size = new System.Drawing.Size(149, 45);
            this.manageTeam_btn.TabIndex = 0;
            this.manageTeam_btn.Text = "Manage Team";
            this.manageTeam_btn.UseVisualStyleBackColor = true;
            this.manageTeam_btn.Click += new System.EventHandler(this.manageTeam_btn_Click);
            // 
            // SettingTab
            // 
            this.SettingTab.Controls.Add(this.groupBox3);
            this.SettingTab.Controls.Add(this.cancelSettings_btn);
            this.SettingTab.Controls.Add(this.groupBox2);
            this.SettingTab.Controls.Add(this.groupBox1);
            this.SettingTab.Location = new System.Drawing.Point(4, 22);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingTab.Size = new System.Drawing.Size(797, 426);
            this.SettingTab.TabIndex = 1;
            this.SettingTab.Text = "Settings";
            this.SettingTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveLanguage_btn);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(193, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 60);
            this.groupBox3.TabIndex = 16;
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
            this.cancelSettings_btn.Location = new System.Drawing.Point(677, 377);
            this.cancelSettings_btn.Name = "cancelSettings_btn";
            this.cancelSettings_btn.Size = new System.Drawing.Size(114, 41);
            this.cancelSettings_btn.TabIndex = 14;
            this.cancelSettings_btn.Text = "Cancel";
            this.cancelSettings_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveFileSettings_btn);
            this.groupBox2.Controls.Add(this.pathTextSettings);
            this.groupBox2.Controls.Add(this.SearchFile);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 78);
            this.groupBox2.TabIndex = 6;
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
            this.groupBox1.Controls.Add(this.saveStartMode_btn);
            this.groupBox1.Controls.Add(this.advanced_rbn_settings);
            this.groupBox1.Controls.Add(this.regular_rbn_mode);
            this.groupBox1.Location = new System.Drawing.Point(9, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 60);
            this.groupBox1.TabIndex = 6;
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
            // MaskInside
            // 
            this.MaskInside.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MaskInside.Controls.Add(this.regular_rbn);
            this.MaskInside.Controls.Add(this.advanced_rbn);
            this.MaskInside.Controls.Add(this.openTable);
            this.MaskInside.Controls.Add(this.pathText);
            this.MaskInside.Controls.Add(this.SearchPath);
            this.MaskInside.Controls.Add(this.label1);
            this.MaskInside.Controls.Add(this.btn_Update);
            this.MaskInside.Controls.Add(this.bindingNavigator1);
            this.MaskInside.Controls.Add(this.dataGridView1);
            this.MaskInside.Controls.Add(this.comboBox1);
            this.MaskInside.Controls.Add(this.btn_show);
            this.MaskInside.Location = new System.Drawing.Point(4, 22);
            this.MaskInside.Name = "MaskInside";
            this.MaskInside.Padding = new System.Windows.Forms.Padding(3);
            this.MaskInside.Size = new System.Drawing.Size(797, 426);
            this.MaskInside.TabIndex = 0;
            this.MaskInside.Text = "Mask";
            // 
            // regular_rbn
            // 
            this.regular_rbn.AutoSize = true;
            this.regular_rbn.Location = new System.Drawing.Point(722, 55);
            this.regular_rbn.Name = "regular_rbn";
            this.regular_rbn.Size = new System.Drawing.Size(62, 17);
            this.regular_rbn.TabIndex = 22;
            this.regular_rbn.TabStop = true;
            this.regular_rbn.Text = "Regular";
            this.regular_rbn.UseVisualStyleBackColor = true;
            this.regular_rbn.CheckedChanged += new System.EventHandler(this.regular_rbn_CheckedChanged_1);
            // 
            // advanced_rbn
            // 
            this.advanced_rbn.AutoSize = true;
            this.advanced_rbn.Location = new System.Drawing.Point(722, 27);
            this.advanced_rbn.Name = "advanced_rbn";
            this.advanced_rbn.Size = new System.Drawing.Size(74, 17);
            this.advanced_rbn.TabIndex = 21;
            this.advanced_rbn.TabStop = true;
            this.advanced_rbn.Text = "Advanced";
            this.advanced_rbn.UseVisualStyleBackColor = true;
            this.advanced_rbn.CheckedChanged += new System.EventHandler(this.advanced_rbn_CheckedChanged_1);
            // 
            // openTable
            // 
            this.openTable.Location = new System.Drawing.Point(453, 49);
            this.openTable.Name = "openTable";
            this.openTable.Size = new System.Drawing.Size(75, 23);
            this.openTable.TabIndex = 20;
            this.openTable.Text = "Open";
            this.openTable.UseVisualStyleBackColor = true;
            this.openTable.Click += new System.EventHandler(this.openTable_Click_1);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(24, 23);
            this.pathText.Multiline = true;
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(504, 21);
            this.pathText.TabIndex = 19;
            // 
            // SearchPath
            // 
            this.SearchPath.Location = new System.Drawing.Point(24, 49);
            this.SearchPath.Name = "SearchPath";
            this.SearchPath.Size = new System.Drawing.Size(423, 23);
            this.SearchPath.TabIndex = 18;
            this.SearchPath.Tag = "";
            this.SearchPath.Text = "Durchsuchen";
            this.SearchPath.UseVisualStyleBackColor = true;
            this.SearchPath.Click += new System.EventHandler(this.SearchPath_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tables";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(582, 79);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 23);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update Table";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 398);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(791, 25);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 262);
            this.dataGridView1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(582, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(582, 50);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(121, 23);
            this.btn_show.TabIndex = 12;
            this.btn_show.Text = "Show Table";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MaskInside);
            this.TabControl.Controls.Add(this.SettingTab);
            this.TabControl.Location = new System.Drawing.Point(180, -5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(805, 452);
            this.TabControl.TabIndex = 12;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advancedManager_grpb);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "Application";
            this.Text = "Application | Beta Release 0.0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.advancedManager_grpb.ResumeLayout(false);
            this.advancedManager_grpb.PerformLayout();
            this.SettingTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MaskInside.ResumeLayout(false);
            this.MaskInside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.GroupBox advancedManager_grpb;
        private System.Windows.Forms.Button manageStrecke_btn;
        private System.Windows.Forms.Button manageWettkampf_btn;
        private System.Windows.Forms.Button manageTeilnahme_btn;
        private System.Windows.Forms.Button manageFahrer_btn;
        private System.Windows.Forms.Button manageTeam_btn;
        private System.Windows.Forms.Button showResults_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage SettingTab;
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
        private System.Windows.Forms.TabPage MaskInside;
        private System.Windows.Forms.RadioButton regular_rbn;
        private System.Windows.Forms.RadioButton advanced_rbn;
        private System.Windows.Forms.Button openTable;
        public System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button SearchPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TabControl TabControl;
    }
}

