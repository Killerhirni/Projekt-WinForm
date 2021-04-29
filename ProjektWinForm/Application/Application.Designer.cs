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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.advancedManager_grpb.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.advancedManager_grpb.Text = "Manager";
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
            this.manageFahrer_btn.Click += new System.EventHandler(this.manageFahrer_btn_Click);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.openTable);
            this.groupBox4.Controls.Add(this.pathText);
            this.groupBox4.Controls.Add(this.SearchPath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_Update);
            this.groupBox4.Controls.Add(this.bindingNavigator1);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.btn_show);
            this.groupBox4.Location = new System.Drawing.Point(192, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 435);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced Manager";
            // 
            // openTable
            // 
            this.openTable.Location = new System.Drawing.Point(451, 48);
            this.openTable.Name = "openTable";
            this.openTable.Size = new System.Drawing.Size(75, 23);
            this.openTable.TabIndex = 29;
            this.openTable.Text = "Open";
            this.openTable.UseVisualStyleBackColor = true;
            this.openTable.Click += new System.EventHandler(this.openTable_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(22, 22);
            this.pathText.Multiline = true;
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(504, 21);
            this.pathText.TabIndex = 28;
            // 
            // SearchPath
            // 
            this.SearchPath.Location = new System.Drawing.Point(22, 48);
            this.SearchPath.Name = "SearchPath";
            this.SearchPath.Size = new System.Drawing.Size(423, 23);
            this.SearchPath.TabIndex = 27;
            this.SearchPath.Tag = "";
            this.SearchPath.Text = "Durchsuchen";
            this.SearchPath.UseVisualStyleBackColor = true;
            this.SearchPath.Click += new System.EventHandler(this.SearchPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tables";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(580, 83);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 23);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Update Table";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 407);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(789, 25);
            this.bindingNavigator1.TabIndex = 24;
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 262);
            this.dataGridView1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(580, 54);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(121, 23);
            this.btn_show.TabIndex = 21;
            this.btn_show.Text = "Show Table";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click_1);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.advancedManager_grpb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "Application";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.advancedManager_grpb.ResumeLayout(false);
            this.advancedManager_grpb.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox4;
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
    }
}

