using MetroFramework.Components;
namespace SpringBootCodeFactory
{
    partial class FormCodeTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCodeTool));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lvEntity = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEntity = new MetroFramework.Controls.MetroButton();
            this.btnRemoveEntity = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.lblUrl = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtDBName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.btnLoadDB = new MetroFramework.Controls.MetroButton();
            this.lvProperty = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMethod = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelelctAll = new MetroFramework.Controls.MetroButton();
            this.btnSelelctID = new MetroFramework.Controls.MetroButton();
            this.btnInsert = new MetroFramework.Controls.MetroButton();
            this.btnGerenation = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnRemoveMethod = new MetroFramework.Controls.MetroButton();
            this.btnAddMethod = new MetroFramework.Controls.MetroButton();
            this.txtMethodName = new MetroFramework.Controls.MetroTextBox();
            this.cbList = new MetroFramework.Controls.MetroCheckBox();
            this.txtParamOut = new MetroFramework.Controls.MetroTextBox();
            this.ckOverride = new MetroFramework.Controls.MetroCheckBox();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtVersion = new MetroFramework.Controls.MetroTextBox();
            this.lblVerion = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.rbSelelct = new MetroFramework.Controls.MetroRadioButton();
            this.rbUpdate = new MetroFramework.Controls.MetroRadioButton();
            this.rbInsert = new MetroFramework.Controls.MetroRadioButton();
            this.rbDelete = new MetroFramework.Controls.MetroRadioButton();
            this.btnAll = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.chEnable = new MetroFramework.Controls.MetroCheckBox();
            this.lvDataSource = new System.Windows.Forms.ListView();
            this.hDSName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblName1 = new MetroFramework.Controls.MetroLabel();
            this.lblReturn = new MetroFramework.Controls.MetroLabel();
            this.gbService = new MetroFramework.Controls.MetroPanel();
            this.lblUrl2 = new MetroFramework.Controls.MetroLabel();
            this.txtDomainName = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.lblName2 = new MetroFramework.Controls.MetroLabel();
            this.gbSource = new MetroFramework.Controls.MetroPanel();
            this.txtDBPort = new MetroFramework.Controls.MetroTextBox();
            this.lblDBPort = new MetroFramework.Controls.MetroLabel();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnAddDS = new MetroFramework.Controls.MetroButton();
            this.titleDataSource = new MetroFramework.Controls.MetroLabel();
            this.btnRemoveDS = new MetroFramework.Controls.MetroButton();
            this.gbEntity = new MetroFramework.Controls.MetroPanel();
            this.titleEntity = new MetroFramework.Controls.MetroLabel();
            this.txtEntity = new MetroFramework.Controls.MetroComboBox();
            this.gbProperty = new MetroFramework.Controls.MetroPanel();
            this.titleProperty = new MetroFramework.Controls.MetroLabel();
            this.gbMethod = new MetroFramework.Controls.MetroPanel();
            this.txtParamIn = new MetroFramework.Controls.MetroTextBox();
            this.lblParam = new MetroFramework.Controls.MetroLabel();
            this.titleMethod = new MetroFramework.Controls.MetroLabel();
            this.menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.codeControl = new SpringBootCodeFactory.code.view.CodeControl();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.gbService.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbEntity.SuspendLayout();
            this.gbProperty.SuspendLayout();
            this.gbMethod.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lvEntity
            // 
            this.lvEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvEntity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvEntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEntity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader});
            this.lvEntity.FullRowSelect = true;
            this.lvEntity.GridLines = true;
            this.lvEntity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEntity.HideSelection = false;
            this.lvEntity.Location = new System.Drawing.Point(0, 116);
            this.lvEntity.MultiSelect = false;
            this.lvEntity.Name = "lvEntity";
            this.lvEntity.Size = new System.Drawing.Size(193, 188);
            this.lvEntity.TabIndex = 35;
            this.lvEntity.UseCompatibleStateImageBehavior = false;
            this.lvEntity.View = System.Windows.Forms.View.Details;
            this.lvEntity.SelectedIndexChanged += new System.EventHandler(this.lvEntity_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "Entity Name";
            this.ColumnHeader.Width = 157;
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEntity.ForeColor = System.Drawing.Color.Black;
            this.btnAddEntity.Location = new System.Drawing.Point(11, 87);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(35, 23);
            this.btnAddEntity.TabIndex = 32;
            this.btnAddEntity.Text = "+";
            this.btnAddEntity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddEntity.UseSelectable = true;
            this.btnAddEntity.Click += new System.EventHandler(this.btnAddEntity_Click);
            // 
            // btnRemoveEntity
            // 
            this.btnRemoveEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveEntity.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveEntity.Location = new System.Drawing.Point(47, 87);
            this.btnRemoveEntity.Name = "btnRemoveEntity";
            this.btnRemoveEntity.Size = new System.Drawing.Size(35, 23);
            this.btnRemoveEntity.TabIndex = 33;
            this.btnRemoveEntity.Text = "-";
            this.btnRemoveEntity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveEntity.UseSelectable = true;
            this.btnRemoveEntity.Click += new System.EventHandler(this.btnRemoveEntity_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(378, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save(&S)";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(378, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(81, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open(&O)";
            this.btnOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOpen.UseSelectable = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtName
            // 
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(83, 8);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(289, 21);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(57, 38);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.Size = new System.Drawing.Size(136, 21);
            this.txtUrl.TabIndex = 21;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.TextChanged += new System.EventHandler(this.btnChangeDS_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrl.AutoSize = true;
            this.lblUrl.ForeColor = System.Drawing.Color.White;
            this.lblUrl.Location = new System.Drawing.Point(6, 40);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 19);
            this.lblUrl.TabIndex = 8;
            this.lblUrl.Text = "URL";
            this.lblUrl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(57, 84);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(136, 21);
            this.txtUser.TabIndex = 23;
            this.txtUser.UseSelectable = true;
            this.txtUser.TextChanged += new System.EventHandler(this.btnChangeDS_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(6, 86);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 19);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User";
            this.lblUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(57, 107);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(136, 21);
            this.txtPass.TabIndex = 24;
            this.txtPass.UseSelectable = true;
            this.txtPass.TextChanged += new System.EventHandler(this.btnChangeDS_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDBName.Lines = new string[0];
            this.txtDBName.Location = new System.Drawing.Point(57, 61);
            this.txtDBName.MaxLength = 32767;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.PasswordChar = '\0';
            this.txtDBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBName.SelectedText = "";
            this.txtDBName.Size = new System.Drawing.Size(136, 21);
            this.txtDBName.TabIndex = 22;
            this.txtDBName.UseSelectable = true;
            this.txtDBName.TextChanged += new System.EventHandler(this.btnChangeDS_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(5, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            this.lblName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.ForeColor = System.Drawing.Color.Black;
            this.btnLoadDB.Location = new System.Drawing.Point(83, 87);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(106, 23);
            this.btnLoadDB.TabIndex = 34;
            this.btnLoadDB.Text = "Load DB(&L)";
            this.btnLoadDB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoadDB.UseSelectable = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // lvProperty
            // 
            this.lvProperty.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvProperty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProperty.CheckBoxes = true;
            this.lvProperty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvProperty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvProperty.FullRowSelect = true;
            this.lvProperty.GridLines = true;
            this.lvProperty.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProperty.HideSelection = false;
            this.lvProperty.Location = new System.Drawing.Point(0, 38);
            this.lvProperty.MultiSelect = false;
            this.lvProperty.Name = "lvProperty";
            this.lvProperty.Size = new System.Drawing.Size(270, 227);
            this.lvProperty.TabIndex = 42;
            this.lvProperty.UseCompatibleStateImageBehavior = false;
            this.lvProperty.View = System.Windows.Forms.View.Details;
            this.lvProperty.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProperty_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Property Name";
            this.columnHeader1.Width = 203;
            // 
            // lvMethod
            // 
            this.lvMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMethod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMethod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvMethod.FullRowSelect = true;
            this.lvMethod.GridLines = true;
            this.lvMethod.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMethod.HideSelection = false;
            this.lvMethod.Location = new System.Drawing.Point(1, 114);
            this.lvMethod.MultiSelect = false;
            this.lvMethod.Name = "lvMethod";
            this.lvMethod.Size = new System.Drawing.Size(183, 188);
            this.lvMethod.TabIndex = 61;
            this.lvMethod.UseCompatibleStateImageBehavior = false;
            this.lvMethod.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Method Name";
            this.columnHeader2.Width = 136;
            // 
            // btnSelelctAll
            // 
            this.btnSelelctAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelelctAll.ForeColor = System.Drawing.Color.Black;
            this.btnSelelctAll.Location = new System.Drawing.Point(191, 183);
            this.btnSelelctAll.Name = "btnSelelctAll";
            this.btnSelelctAll.Size = new System.Drawing.Size(73, 23);
            this.btnSelelctAll.TabIndex = 64;
            this.btnSelelctAll.Text = "Select All";
            this.btnSelelctAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSelelctAll.UseSelectable = true;
            this.btnSelelctAll.Click += new System.EventHandler(this.btnSelelctAll_Click);
            // 
            // btnSelelctID
            // 
            this.btnSelelctID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelelctID.ForeColor = System.Drawing.Color.Black;
            this.btnSelelctID.Location = new System.Drawing.Point(191, 206);
            this.btnSelelctID.Name = "btnSelelctID";
            this.btnSelelctID.Size = new System.Drawing.Size(73, 23);
            this.btnSelelctID.TabIndex = 65;
            this.btnSelelctID.Text = "SelectByID";
            this.btnSelelctID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSelelctID.UseSelectable = true;
            this.btnSelelctID.Click += new System.EventHandler(this.btnSelelctID_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(191, 229);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(73, 23);
            this.btnInsert.TabIndex = 66;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInsert.UseSelectable = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnGerenation
            // 
            this.btnGerenation.ForeColor = System.Drawing.Color.Black;
            this.btnGerenation.Location = new System.Drawing.Point(378, 83);
            this.btnGerenation.Name = "btnGerenation";
            this.btnGerenation.Size = new System.Drawing.Size(81, 23);
            this.btnGerenation.TabIndex = 8;
            this.btnGerenation.Text = "Generate(&G)";
            this.btnGerenation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnGerenation.UseSelectable = true;
            this.btnGerenation.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(191, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 23);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveMethod
            // 
            this.btnRemoveMethod.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveMethod.Location = new System.Drawing.Point(165, 6);
            this.btnRemoveMethod.Name = "btnRemoveMethod";
            this.btnRemoveMethod.Size = new System.Drawing.Size(35, 23);
            this.btnRemoveMethod.TabIndex = 55;
            this.btnRemoveMethod.Text = "-";
            this.btnRemoveMethod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveMethod.UseSelectable = true;
            this.btnRemoveMethod.Click += new System.EventHandler(this.btnRemoveMethod_Click);
            // 
            // btnAddMethod
            // 
            this.btnAddMethod.ForeColor = System.Drawing.Color.Black;
            this.btnAddMethod.Location = new System.Drawing.Point(129, 6);
            this.btnAddMethod.Name = "btnAddMethod";
            this.btnAddMethod.Size = new System.Drawing.Size(35, 23);
            this.btnAddMethod.TabIndex = 54;
            this.btnAddMethod.Text = "+";
            this.btnAddMethod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddMethod.UseSelectable = true;
            this.btnAddMethod.Click += new System.EventHandler(this.btnAddMethod_Click);
            // 
            // txtMethodName
            // 
            this.txtMethodName.Lines = new string[0];
            this.txtMethodName.Location = new System.Drawing.Point(63, 41);
            this.txtMethodName.MaxLength = 32767;
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.PasswordChar = '\0';
            this.txtMethodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMethodName.SelectedText = "";
            this.txtMethodName.Size = new System.Drawing.Size(115, 21);
            this.txtMethodName.TabIndex = 51;
            this.txtMethodName.UseSelectable = true;
            // 
            // cbList
            // 
            this.cbList.AutoSize = true;
            this.cbList.ForeColor = System.Drawing.Color.White;
            this.cbList.Location = new System.Drawing.Point(203, 94);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(52, 15);
            this.cbList.TabIndex = 56;
            this.cbList.Text = "Is List";
            this.cbList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbList.UseSelectable = true;
            // 
            // txtParamOut
            // 
            this.txtParamOut.Lines = new string[0];
            this.txtParamOut.Location = new System.Drawing.Point(63, 89);
            this.txtParamOut.MaxLength = 32767;
            this.txtParamOut.Name = "txtParamOut";
            this.txtParamOut.PasswordChar = '\0';
            this.txtParamOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParamOut.SelectedText = "";
            this.txtParamOut.Size = new System.Drawing.Size(115, 21);
            this.txtParamOut.TabIndex = 53;
            this.txtParamOut.UseSelectable = true;
            // 
            // ckOverride
            // 
            this.ckOverride.AutoSize = true;
            this.ckOverride.Location = new System.Drawing.Point(382, 62);
            this.ckOverride.Name = "ckOverride";
            this.ckOverride.Size = new System.Drawing.Size(68, 15);
            this.ckOverride.TabIndex = 7;
            this.ckOverride.Text = "Override";
            this.ckOverride.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ckOverride.UseSelectable = true;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(11, 35);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 19);
            this.lblPort.TabIndex = 47;
            this.lblPort.Text = "Port";
            this.lblPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPort
            // 
            this.txtPort.Lines = new string[] {
        "8080"};
            this.txtPort.Location = new System.Drawing.Point(83, 34);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.Size = new System.Drawing.Size(289, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8080";
            this.txtPort.UseSelectable = true;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtVersion
            // 
            this.txtVersion.Lines = new string[] {
        "1.0.0.0"};
            this.txtVersion.Location = new System.Drawing.Point(83, 60);
            this.txtVersion.MaxLength = 32767;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.PasswordChar = '\0';
            this.txtVersion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVersion.SelectedText = "";
            this.txtVersion.Size = new System.Drawing.Size(289, 21);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.Text = "1.0.0.0";
            this.txtVersion.UseSelectable = true;
            this.txtVersion.TextChanged += new System.EventHandler(this.txtVersion_TextChanged);
            // 
            // lblVerion
            // 
            this.lblVerion.AutoSize = true;
            this.lblVerion.Location = new System.Drawing.Point(11, 59);
            this.lblVerion.Name = "lblVerion";
            this.lblVerion.Size = new System.Drawing.Size(52, 19);
            this.lblVerion.TabIndex = 50;
            this.lblVerion.Text = "Version";
            this.lblVerion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(191, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbSelelct
            // 
            this.rbSelelct.AutoSize = true;
            this.rbSelelct.Checked = true;
            this.rbSelelct.ForeColor = System.Drawing.Color.White;
            this.rbSelelct.Location = new System.Drawing.Point(203, 6);
            this.rbSelelct.Name = "rbSelelct";
            this.rbSelelct.Size = new System.Drawing.Size(56, 15);
            this.rbSelelct.TabIndex = 57;
            this.rbSelelct.TabStop = true;
            this.rbSelelct.Text = "selelct";
            this.rbSelelct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbSelelct.UseSelectable = true;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.ForeColor = System.Drawing.Color.White;
            this.rbUpdate.Location = new System.Drawing.Point(203, 50);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(60, 15);
            this.rbUpdate.TabIndex = 59;
            this.rbUpdate.Text = "update";
            this.rbUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbUpdate.UseSelectable = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.ForeColor = System.Drawing.Color.White;
            this.rbInsert.Location = new System.Drawing.Point(203, 28);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(52, 15);
            this.rbInsert.TabIndex = 58;
            this.rbInsert.Text = "insert";
            this.rbInsert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbInsert.UseSelectable = true;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.ForeColor = System.Drawing.Color.White;
            this.rbDelete.Location = new System.Drawing.Point(203, 72);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(55, 15);
            this.rbDelete.TabIndex = 60;
            this.rbDelete.Text = "delete";
            this.rbDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbDelete.UseSelectable = true;
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Location = new System.Drawing.Point(191, 117);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(73, 23);
            this.btnAll.TabIndex = 62;
            this.btnAll.Text = "All(&A)";
            this.btnAll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAll.UseSelectable = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(191, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 23);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear(&C)";
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chEnable
            // 
            this.chEnable.AutoSize = true;
            this.chEnable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chEnable.Location = new System.Drawing.Point(159, 10);
            this.chEnable.Name = "chEnable";
            this.chEnable.Size = new System.Drawing.Size(75, 15);
            this.chEnable.TabIndex = 41;
            this.chEnable.Text = "Enable All";
            this.chEnable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chEnable.UseSelectable = true;
            this.chEnable.CheckedChanged += new System.EventHandler(this.chEnable_CheckedChanged);
            // 
            // lvDataSource
            // 
            this.lvDataSource.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvDataSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDataSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hDSName});
            this.lvDataSource.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvDataSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvDataSource.FullRowSelect = true;
            this.lvDataSource.GridLines = true;
            this.lvDataSource.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDataSource.HideSelection = false;
            this.lvDataSource.Location = new System.Drawing.Point(0, 180);
            this.lvDataSource.MultiSelect = false;
            this.lvDataSource.Name = "lvDataSource";
            this.lvDataSource.Size = new System.Drawing.Size(195, 85);
            this.lvDataSource.TabIndex = 28;
            this.lvDataSource.UseCompatibleStateImageBehavior = false;
            this.lvDataSource.View = System.Windows.Forms.View.Details;
            this.lvDataSource.SelectedIndexChanged += new System.EventHandler(this.lvDataSource_SelectedIndexChanged);
            // 
            // hDSName
            // 
            this.hDSName.Text = "DB Name";
            this.hDSName.Width = 157;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.BackColor = System.Drawing.Color.Transparent;
            this.lblName1.ForeColor = System.Drawing.Color.White;
            this.lblName1.Location = new System.Drawing.Point(3, 40);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(45, 19);
            this.lblName1.TabIndex = 61;
            this.lblName1.Text = "Name";
            this.lblName1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.ForeColor = System.Drawing.Color.White;
            this.lblReturn.Location = new System.Drawing.Point(3, 89);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(47, 19);
            this.lblReturn.TabIndex = 62;
            this.lblReturn.Text = "Return";
            this.lblReturn.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gbService
            // 
            this.gbService.BackColor = System.Drawing.Color.Transparent;
            this.gbService.Controls.Add(this.lblUrl2);
            this.gbService.Controls.Add(this.txtDomainName);
            this.gbService.Controls.Add(this.btnOpen);
            this.gbService.Controls.Add(this.btnSave);
            this.gbService.Controls.Add(this.ckOverride);
            this.gbService.Controls.Add(this.btnGerenation);
            this.gbService.Controls.Add(this.label1);
            this.gbService.Controls.Add(this.txtName);
            this.gbService.Controls.Add(this.lblPort);
            this.gbService.Controls.Add(this.txtPort);
            this.gbService.Controls.Add(this.txtVersion);
            this.gbService.Controls.Add(this.lblVerion);
            this.gbService.ForeColor = System.Drawing.Color.White;
            this.gbService.HorizontalScrollbarBarColor = true;
            this.gbService.HorizontalScrollbarHighlightOnWheel = false;
            this.gbService.HorizontalScrollbarSize = 10;
            this.gbService.Location = new System.Drawing.Point(22, 63);
            this.gbService.Name = "gbService";
            this.gbService.Size = new System.Drawing.Size(465, 114);
            this.gbService.TabIndex = 63;
            this.gbService.Text = "工程";
            this.gbService.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbService.VerticalScrollbarBarColor = true;
            this.gbService.VerticalScrollbarHighlightOnWheel = false;
            this.gbService.VerticalScrollbarSize = 10;
            // 
            // lblUrl2
            // 
            this.lblUrl2.AutoSize = true;
            this.lblUrl2.ForeColor = System.Drawing.Color.White;
            this.lblUrl2.Location = new System.Drawing.Point(11, 84);
            this.lblUrl2.Name = "lblUrl2";
            this.lblUrl2.Size = new System.Drawing.Size(32, 19);
            this.lblUrl2.TabIndex = 52;
            this.lblUrl2.Text = "URL";
            this.lblUrl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDomainName
            // 
            this.txtDomainName.Lines = new string[] {
        "https://localhost/"};
            this.txtDomainName.Location = new System.Drawing.Point(83, 86);
            this.txtDomainName.MaxLength = 32767;
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.PasswordChar = '\0';
            this.txtDomainName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDomainName.SelectedText = "";
            this.txtDomainName.Size = new System.Drawing.Size(289, 21);
            this.txtDomainName.TabIndex = 4;
            this.txtDomainName.Text = "https://localhost/";
            this.txtDomainName.UseSelectable = true;
            this.txtDomainName.TextChanged += new System.EventHandler(this.txtDomainName_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(6, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 19);
            this.lblPassword.TabIndex = 64;
            this.lblPassword.Text = "Pass";
            this.lblPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblName2
            // 
            this.lblName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName2.AutoSize = true;
            this.lblName2.ForeColor = System.Drawing.Color.White;
            this.lblName2.Location = new System.Drawing.Point(6, 63);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(45, 19);
            this.lblName2.TabIndex = 65;
            this.lblName2.Text = "Name";
            this.lblName2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gbSource
            // 
            this.gbSource.BackColor = System.Drawing.Color.DimGray;
            this.gbSource.Controls.Add(this.txtDBPort);
            this.gbSource.Controls.Add(this.lblDBPort);
            this.gbSource.Controls.Add(this.lblInfo);
            this.gbSource.Controls.Add(this.txtDescription);
            this.gbSource.Controls.Add(this.lvDataSource);
            this.gbSource.Controls.Add(this.lblName2);
            this.gbSource.Controls.Add(this.btnAddDS);
            this.gbSource.Controls.Add(this.titleDataSource);
            this.gbSource.Controls.Add(this.lblUrl);
            this.gbSource.Controls.Add(this.lblPassword);
            this.gbSource.Controls.Add(this.btnRemoveDS);
            this.gbSource.Controls.Add(this.txtUrl);
            this.gbSource.Controls.Add(this.lblUser);
            this.gbSource.Controls.Add(this.txtUser);
            this.gbSource.Controls.Add(this.txtPass);
            this.gbSource.Controls.Add(this.txtDBName);
            this.gbSource.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSource.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbSource.HorizontalScrollbarBarColor = true;
            this.gbSource.HorizontalScrollbarHighlightOnWheel = false;
            this.gbSource.HorizontalScrollbarSize = 10;
            this.gbSource.Location = new System.Drawing.Point(22, 183);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(195, 265);
            this.gbSource.TabIndex = 67;
            this.gbSource.Text = "数据源";
            this.gbSource.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbSource.VerticalScrollbarBarColor = true;
            this.gbSource.VerticalScrollbarHighlightOnWheel = false;
            this.gbSource.VerticalScrollbarSize = 10;
            // 
            // txtDBPort
            // 
            this.txtDBPort.Lines = new string[0];
            this.txtDBPort.Location = new System.Drawing.Point(57, 153);
            this.txtDBPort.MaxLength = 32767;
            this.txtDBPort.Name = "txtDBPort";
            this.txtDBPort.PasswordChar = '\0';
            this.txtDBPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBPort.SelectedText = "3306";
            this.txtDBPort.Size = new System.Drawing.Size(135, 21);
            this.txtDBPort.TabIndex = 71;
            this.txtDBPort.UseSelectable = true;
            this.txtDBPort.TextChanged += new System.EventHandler(btnChangeDS_Click);
            // 
            // lblDBPort
            // 
            this.lblDBPort.AutoSize = true;
            this.lblDBPort.Location = new System.Drawing.Point(6, 156);
            this.lblDBPort.Name = "lblDBPort";
            this.lblDBPort.Size = new System.Drawing.Size(34, 19);
            this.lblDBPort.TabIndex = 70;
            this.lblDBPort.Text = "Port";
            this.lblDBPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(6, 132);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 19);
            this.lblInfo.TabIndex = 69;
            this.lblInfo.Text = "Info";
            this.lblInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(57, 130);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(136, 21);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnAddDS
            // 
            this.btnAddDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDS.ForeColor = System.Drawing.Color.Black;
            this.btnAddDS.Location = new System.Drawing.Point(114, 9);
            this.btnAddDS.Name = "btnAddDS";
            this.btnAddDS.Size = new System.Drawing.Size(35, 23);
            this.btnAddDS.TabIndex = 26;
            this.btnAddDS.Text = "+";
            this.btnAddDS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddDS.UseSelectable = true;
            this.btnAddDS.Click += new System.EventHandler(this.btnAddDS_Click);
            // 
            // titleDataSource
            // 
            this.titleDataSource.AutoSize = true;
            this.titleDataSource.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleDataSource.Location = new System.Drawing.Point(2, 7);
            this.titleDataSource.Name = "titleDataSource";
            this.titleDataSource.Size = new System.Drawing.Size(105, 25);
            this.titleDataSource.TabIndex = 0;
            this.titleDataSource.Text = "Source View";
            this.titleDataSource.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnRemoveDS
            // 
            this.btnRemoveDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDS.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveDS.Location = new System.Drawing.Point(151, 9);
            this.btnRemoveDS.Name = "btnRemoveDS";
            this.btnRemoveDS.Size = new System.Drawing.Size(35, 23);
            this.btnRemoveDS.TabIndex = 27;
            this.btnRemoveDS.Text = "-";
            this.btnRemoveDS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveDS.UseSelectable = true;
            this.btnRemoveDS.Click += new System.EventHandler(this.btnRemoveDS_Click);
            // 
            // gbEntity
            // 
            this.gbEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbEntity.BackColor = System.Drawing.Color.DimGray;
            this.gbEntity.Controls.Add(this.lvEntity);
            this.gbEntity.Controls.Add(this.titleEntity);
            this.gbEntity.Controls.Add(this.txtEntity);
            this.gbEntity.Controls.Add(this.lblName);
            this.gbEntity.Controls.Add(this.btnAddEntity);
            this.gbEntity.Controls.Add(this.btnRemoveEntity);
            this.gbEntity.Controls.Add(this.btnLoadDB);
            this.gbEntity.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbEntity.HorizontalScrollbarBarColor = true;
            this.gbEntity.HorizontalScrollbarHighlightOnWheel = false;
            this.gbEntity.HorizontalScrollbarSize = 10;
            this.gbEntity.Location = new System.Drawing.Point(22, 454);
            this.gbEntity.Name = "gbEntity";
            this.gbEntity.Size = new System.Drawing.Size(195, 304);
            this.gbEntity.TabIndex = 68;
            this.gbEntity.Text = "实体";
            this.gbEntity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbEntity.VerticalScrollbarBarColor = true;
            this.gbEntity.VerticalScrollbarHighlightOnWheel = false;
            this.gbEntity.VerticalScrollbarSize = 10;
            // 
            // titleEntity
            // 
            this.titleEntity.AutoSize = true;
            this.titleEntity.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleEntity.Location = new System.Drawing.Point(1, 4);
            this.titleEntity.Name = "titleEntity";
            this.titleEntity.Size = new System.Drawing.Size(94, 25);
            this.titleEntity.TabIndex = 0;
            this.titleEntity.Text = "Entity View";
            this.titleEntity.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtEntity
            // 
            this.txtEntity.FormattingEnabled = true;
            this.txtEntity.ItemHeight = 23;
            this.txtEntity.Location = new System.Drawing.Point(60, 42);
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(129, 29);
            this.txtEntity.TabIndex = 31;
            this.txtEntity.UseSelectable = true;
            // 
            // gbProperty
            // 
            this.gbProperty.BackColor = System.Drawing.Color.DimGray;
            this.gbProperty.Controls.Add(this.lvProperty);
            this.gbProperty.Controls.Add(this.chEnable);
            this.gbProperty.Controls.Add(this.titleProperty);
            this.gbProperty.ForeColor = System.Drawing.Color.GreenYellow;
            this.gbProperty.HorizontalScrollbarBarColor = true;
            this.gbProperty.HorizontalScrollbarHighlightOnWheel = false;
            this.gbProperty.HorizontalScrollbarSize = 10;
            this.gbProperty.Location = new System.Drawing.Point(221, 183);
            this.gbProperty.Name = "gbProperty";
            this.gbProperty.Size = new System.Drawing.Size(270, 265);
            this.gbProperty.TabIndex = 69;
            this.gbProperty.Text = "属性";
            this.gbProperty.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbProperty.VerticalScrollbarBarColor = true;
            this.gbProperty.VerticalScrollbarHighlightOnWheel = false;
            this.gbProperty.VerticalScrollbarSize = 10;
            // 
            // titleProperty
            // 
            this.titleProperty.AutoSize = true;
            this.titleProperty.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleProperty.Location = new System.Drawing.Point(0, 7);
            this.titleProperty.Name = "titleProperty";
            this.titleProperty.Size = new System.Drawing.Size(117, 25);
            this.titleProperty.TabIndex = 0;
            this.titleProperty.Text = "Property View";
            this.titleProperty.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // gbMethod
            // 
            this.gbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMethod.BackColor = System.Drawing.Color.DimGray;
            this.gbMethod.Controls.Add(this.txtParamIn);
            this.gbMethod.Controls.Add(this.lblParam);
            this.gbMethod.Controls.Add(this.lvMethod);
            this.gbMethod.Controls.Add(this.btnAll);
            this.gbMethod.Controls.Add(this.btnClear);
            this.gbMethod.Controls.Add(this.btnSelelctAll);
            this.gbMethod.Controls.Add(this.btnSelelctID);
            this.gbMethod.Controls.Add(this.titleMethod);
            this.gbMethod.Controls.Add(this.lblReturn);
            this.gbMethod.Controls.Add(this.btnInsert);
            this.gbMethod.Controls.Add(this.lblName1);
            this.gbMethod.Controls.Add(this.rbDelete);
            this.gbMethod.Controls.Add(this.btnUpdate);
            this.gbMethod.Controls.Add(this.rbInsert);
            this.gbMethod.Controls.Add(this.btnDelete);
            this.gbMethod.Controls.Add(this.rbUpdate);
            this.gbMethod.Controls.Add(this.rbSelelct);
            this.gbMethod.Controls.Add(this.txtParamOut);
            this.gbMethod.Controls.Add(this.txtMethodName);
            this.gbMethod.Controls.Add(this.btnAddMethod);
            this.gbMethod.Controls.Add(this.btnRemoveMethod);
            this.gbMethod.Controls.Add(this.cbList);
            this.gbMethod.ForeColor = System.Drawing.Color.LawnGreen;
            this.gbMethod.HorizontalScrollbarBarColor = true;
            this.gbMethod.HorizontalScrollbarHighlightOnWheel = false;
            this.gbMethod.HorizontalScrollbarSize = 10;
            this.gbMethod.Location = new System.Drawing.Point(223, 456);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(270, 302);
            this.gbMethod.TabIndex = 70;
            this.gbMethod.Text = "方法";
            this.gbMethod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbMethod.VerticalScrollbarBarColor = true;
            this.gbMethod.VerticalScrollbarHighlightOnWheel = false;
            this.gbMethod.VerticalScrollbarSize = 10;
            // 
            // txtParamIn
            // 
            this.txtParamIn.Lines = new string[0];
            this.txtParamIn.Location = new System.Drawing.Point(63, 65);
            this.txtParamIn.MaxLength = 32767;
            this.txtParamIn.Name = "txtParamIn";
            this.txtParamIn.PasswordChar = '\0';
            this.txtParamIn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParamIn.SelectedText = "";
            this.txtParamIn.Size = new System.Drawing.Size(115, 21);
            this.txtParamIn.TabIndex = 52;
            this.txtParamIn.UseSelectable = true;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.ForeColor = System.Drawing.Color.White;
            this.lblParam.Location = new System.Drawing.Point(3, 64);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(53, 19);
            this.lblParam.TabIndex = 63;
            this.lblParam.Text = "Params";
            this.lblParam.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // titleMethod
            // 
            this.titleMethod.AutoSize = true;
            this.titleMethod.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleMethod.Location = new System.Drawing.Point(3, 4);
            this.titleMethod.Name = "titleMethod";
            this.titleMethod.Size = new System.Drawing.Size(112, 25);
            this.titleMethod.TabIndex = 0;
            this.titleMethod.Text = "Method View";
            this.titleMethod.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemSave,
            this.itemGenerate,
            this.toolStripMenuItem1,
            this.itemExit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(138, 98);
            this.menu.Text = "File(&F)";
            this.menu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menu.UseCustomBackColor = true;
            this.menu.UseCustomForeColor = true;
            this.menu.UseStyleColors = true;
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(137, 22);
            this.itemOpen.Text = "(&O)pen";
            this.itemOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(137, 22);
            this.itemSave.Text = "(&S)ave";
            this.itemSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // itemGenerate
            // 
            this.itemGenerate.Name = "itemGenerate";
            this.itemGenerate.Size = new System.Drawing.Size(137, 22);
            this.itemGenerate.Text = "(&G)enerate";
            this.itemGenerate.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(137, 22);
            this.itemExit.Text = "(&E)xit";
            this.itemExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // codeControl
            // 
            this.codeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeControl.Enable = false;
            this.codeControl.Location = new System.Drawing.Point(493, 63);
            this.codeControl.Name = "codeControl";
            this.codeControl.Size = new System.Drawing.Size(677, 695);
            this.codeControl.TabIndex = 71;
            this.codeControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.codeControl.UseSelectable = true;
            // 
            // FormCodeTool
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::SpringBootCodeFactory.Properties.Resources.link;
            this.BackImagePadding = new System.Windows.Forms.Padding(250, 10, 0, 0);
            this.BackMaxSize = 50;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1184, 774);
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.gbService);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.gbEntity);
            this.Controls.Add(this.gbMethod);
            this.Controls.Add(this.gbProperty);
            this.Controls.Add(this.codeControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCodeTool";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Code Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.gbService.ResumeLayout(false);
            this.gbService.PerformLayout();
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbEntity.ResumeLayout(false);
            this.gbEntity.PerformLayout();
            this.gbProperty.ResumeLayout(false);
            this.gbProperty.PerformLayout();
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel lblUrl;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroLabel lblVerion;
        private MetroFramework.Controls.MetroLabel lblName1;
        private MetroFramework.Controls.MetroLabel lblReturn;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroLabel lblName2;
        private MetroFramework.Controls.MetroLabel lblParam;
        private MetroFramework.Controls.MetroLabel lblUrl2;
        private MetroFramework.Controls.MetroLabel lblInfo;

        private System.Windows.Forms.ListView lvEntity;
        private System.Windows.Forms.ListView lvProperty;
        private System.Windows.Forms.ListView lvMethod;
        private System.Windows.Forms.ListView lvDataSource;

        private MetroFramework.Controls.MetroButton btnAddEntity;
        private MetroFramework.Controls.MetroButton btnRemoveEntity;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroButton btnLoadDB;
        private MetroFramework.Controls.MetroButton btnSelelctAll;
        private MetroFramework.Controls.MetroButton btnSelelctID;
        private MetroFramework.Controls.MetroButton btnInsert;
        private MetroFramework.Controls.MetroButton btnGerenation;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnRemoveMethod;
        private MetroFramework.Controls.MetroButton btnAddMethod;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAll;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnAddDS;
        private MetroFramework.Controls.MetroButton btnRemoveDS;

        private MetroFramework.Controls.MetroRadioButton rbSelelct;
        private MetroFramework.Controls.MetroRadioButton rbUpdate;
        private MetroFramework.Controls.MetroRadioButton rbInsert;
        private MetroFramework.Controls.MetroRadioButton rbDelete;

        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtUrl;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtDBName;
        private MetroFramework.Controls.MetroTextBox txtParamIn;
        private MetroFramework.Controls.MetroTextBox txtDomainName;
        private MetroFramework.Controls.MetroTextBox txtDescription;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader hDSName;

        private MetroFramework.Controls.MetroCheckBox cbList;
        private MetroFramework.Controls.MetroCheckBox chEnable;
        private MetroFramework.Controls.MetroComboBox txtEntity;

        private MetroFramework.Controls.MetroTextBox txtMethodName;
        private MetroFramework.Controls.MetroTextBox txtParamOut;
        private MetroFramework.Controls.MetroCheckBox ckOverride;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroTextBox txtVersion;

        private MetroFramework.Controls.MetroPanel gbService;
        private MetroFramework.Controls.MetroPanel gbSource;
        private MetroFramework.Controls.MetroPanel gbEntity;
        private MetroFramework.Controls.MetroPanel gbProperty;
        private MetroFramework.Controls.MetroPanel gbMethod;

        private MetroStyleManager metroStyleManager;
        private code.view.CodeControl codeControl;
        private MetroFramework.Controls.MetroLabel titleDataSource;
        private MetroFramework.Controls.MetroLabel titleProperty;
        private MetroFramework.Controls.MetroLabel titleEntity;
        private MetroFramework.Controls.MetroLabel titleMethod;
        private MetroFramework.Controls.MetroContextMenu menu;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ToolStripMenuItem itemGenerate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private MetroFramework.Controls.MetroTextBox txtDBPort;
        private MetroFramework.Controls.MetroLabel lblDBPort;
    }
}

