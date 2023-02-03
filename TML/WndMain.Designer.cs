namespace TML
{
    partial class WndMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.picAvc = new System.Windows.Forms.PictureBox();
            this.btnAccountManage = new System.Windows.Forms.Button();
            this.labAccount = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.ComboBox();
            this.btnManage = new System.Windows.Forms.Button();
            this.labVerChoose = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.lstDownMan = new System.Windows.Forms.ListView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pbarDownload = new System.Windows.Forms.ProgressBar();
            this.editionBox = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.sourceBox = new System.Windows.Forms.ComboBox();
            this.labSource = new System.Windows.Forms.Label();
            this.tabVersion = new System.Windows.Forms.TabPage();
            this.btnAction = new System.Windows.Forms.Button();
            this.cMemuAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.locateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delLocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameLocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delChoseVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locBox = new System.Windows.Forms.ComboBox();
            this.lstManage = new System.Windows.Forms.ListView();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.labAccCa = new System.Windows.Forms.Label();
            this.btnAccMore = new System.Windows.Forms.Button();
            this.accountNameBox = new System.Windows.Forms.ComboBox();
            this.gbAccountCreate = new System.Windows.Forms.GroupBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnMSAcountLogin = new System.Windows.Forms.Button();
            this.labPlayerName = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.accTyCBox = new System.Windows.Forms.ComboBox();
            this.picAvcAccount = new System.Windows.Forms.PictureBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSetJava = new System.Windows.Forms.TabPage();
            this.btnAutoCheckJava = new System.Windows.Forms.Button();
            this.gbJavaEdit = new System.Windows.Forms.GroupBox();
            this.btnJavaChooseLoc = new System.Windows.Forms.Button();
            this.labJavaFolderLoc = new System.Windows.Forms.Label();
            this.tbJavaFolderLoc = new System.Windows.Forms.TextBox();
            this.btnAddEditJava = new System.Windows.Forms.Button();
            this.chbEditOrAdd = new System.Windows.Forms.CheckBox();
            this.labJavaPath = new System.Windows.Forms.Label();
            this.javaPathBox = new System.Windows.Forms.ComboBox();
            this.tabSetMemory = new System.Windows.Forms.TabPage();
            this.gbMemorySet = new System.Windows.Forms.GroupBox();
            this.labMaxMemoryMB = new System.Windows.Forms.Label();
            this.nudMaxMemory = new System.Windows.Forms.NumericUpDown();
            this.labMaxMemory = new System.Windows.Forms.Label();
            this.cMemuAccMore = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改用户名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labMaxAva = new System.Windows.Forms.Label();
            this.timerMemory = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvc)).BeginInit();
            this.tabDownload.SuspendLayout();
            this.tabVersion.SuspendLayout();
            this.cMemuAction.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.gbAccountCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvcAccount)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSetJava.SuspendLayout();
            this.gbJavaEdit.SuspendLayout();
            this.tabSetMemory.SuspendLayout();
            this.gbMemorySet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMemory)).BeginInit();
            this.cMemuAccMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabDownload);
            this.tabControl.Controls.Add(this.tabVersion);
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabSettings);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.picAvc);
            this.tabHome.Controls.Add(this.btnAccountManage);
            this.tabHome.Controls.Add(this.labAccount);
            this.tabHome.Controls.Add(this.accountBox);
            this.tabHome.Controls.Add(this.btnManage);
            this.tabHome.Controls.Add(this.labVerChoose);
            this.tabHome.Controls.Add(this.versionBox);
            this.tabHome.Controls.Add(this.btnLaunch);
            resources.ApplyResources(this.tabHome, "tabHome");
            this.tabHome.Name = "tabHome";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // picAvc
            // 
            resources.ApplyResources(this.picAvc, "picAvc");
            this.picAvc.Name = "picAvc";
            this.picAvc.TabStop = false;
            // 
            // btnAccountManage
            // 
            resources.ApplyResources(this.btnAccountManage, "btnAccountManage");
            this.btnAccountManage.Name = "btnAccountManage";
            this.btnAccountManage.UseVisualStyleBackColor = true;
            this.btnAccountManage.Click += new System.EventHandler(this.btnAccountManage_Click);
            // 
            // labAccount
            // 
            resources.ApplyResources(this.labAccount, "labAccount");
            this.labAccount.Name = "labAccount";
            // 
            // accountBox
            // 
            this.accountBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountBox.FormattingEnabled = true;
            resources.ApplyResources(this.accountBox, "accountBox");
            this.accountBox.Name = "accountBox";
            // 
            // btnManage
            // 
            resources.ApplyResources(this.btnManage, "btnManage");
            this.btnManage.Name = "btnManage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // labVerChoose
            // 
            resources.ApplyResources(this.labVerChoose, "labVerChoose");
            this.labVerChoose.Name = "labVerChoose";
            // 
            // versionBox
            // 
            this.versionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionBox.FormattingEnabled = true;
            resources.ApplyResources(this.versionBox, "versionBox");
            this.versionBox.Name = "versionBox";
            // 
            // btnLaunch
            // 
            resources.ApplyResources(this.btnLaunch, "btnLaunch");
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            // 
            // tabDownload
            // 
            this.tabDownload.Controls.Add(this.lstDownMan);
            this.tabDownload.Controls.Add(this.btnDownload);
            this.tabDownload.Controls.Add(this.pbarDownload);
            this.tabDownload.Controls.Add(this.editionBox);
            this.tabDownload.Controls.Add(this.labType);
            this.tabDownload.Controls.Add(this.sourceBox);
            this.tabDownload.Controls.Add(this.labSource);
            resources.ApplyResources(this.tabDownload, "tabDownload");
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.UseVisualStyleBackColor = true;
            // 
            // lstDownMan
            // 
            this.lstDownMan.HideSelection = false;
            resources.ApplyResources(this.lstDownMan, "lstDownMan");
            this.lstDownMan.Name = "lstDownMan";
            this.lstDownMan.UseCompatibleStateImageBehavior = false;
            this.lstDownMan.View = System.Windows.Forms.View.Details;
            // 
            // btnDownload
            // 
            resources.ApplyResources(this.btnDownload, "btnDownload");
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // pbarDownload
            // 
            resources.ApplyResources(this.pbarDownload, "pbarDownload");
            this.pbarDownload.Name = "pbarDownload";
            // 
            // editionBox
            // 
            this.editionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editionBox.FormattingEnabled = true;
            this.editionBox.Items.AddRange(new object[] {
            resources.GetString("editionBox.Items"),
            resources.GetString("editionBox.Items1"),
            resources.GetString("editionBox.Items2"),
            resources.GetString("editionBox.Items3")});
            resources.ApplyResources(this.editionBox, "editionBox");
            this.editionBox.Name = "editionBox";
            // 
            // labType
            // 
            resources.ApplyResources(this.labType, "labType");
            this.labType.Name = "labType";
            // 
            // sourceBox
            // 
            this.sourceBox.DisplayMember = "0";
            this.sourceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceBox.FormattingEnabled = true;
            this.sourceBox.Items.AddRange(new object[] {
            resources.GetString("sourceBox.Items"),
            resources.GetString("sourceBox.Items1"),
            resources.GetString("sourceBox.Items2")});
            resources.ApplyResources(this.sourceBox, "sourceBox");
            this.sourceBox.Name = "sourceBox";
            // 
            // labSource
            // 
            resources.ApplyResources(this.labSource, "labSource");
            this.labSource.Name = "labSource";
            // 
            // tabVersion
            // 
            this.tabVersion.Controls.Add(this.btnAction);
            this.tabVersion.Controls.Add(this.locBox);
            this.tabVersion.Controls.Add(this.lstManage);
            resources.ApplyResources(this.tabVersion, "tabVersion");
            this.tabVersion.Name = "tabVersion";
            this.tabVersion.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.ContextMenuStrip = this.cMemuAction;
            resources.ApplyResources(this.btnAction, "btnAction");
            this.btnAction.Name = "btnAction";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAction_MouseClick);
            // 
            // cMemuAction
            // 
            this.cMemuAction.DropShadowEnabled = false;
            this.cMemuAction.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cMemuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locateToolStripMenuItem,
            this.openGameLocToolStripMenuItem,
            this.delChoseVerToolStripMenuItem});
            this.cMemuAction.Name = "cMemuAction";
            this.cMemuAction.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            resources.ApplyResources(this.cMemuAction, "cMemuAction");
            // 
            // locateToolStripMenuItem
            // 
            this.locateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocToolStripMenuItem,
            this.delLocToolStripMenuItem,
            this.openLocExplorerToolStripMenuItem});
            this.locateToolStripMenuItem.Name = "locateToolStripMenuItem";
            resources.ApplyResources(this.locateToolStripMenuItem, "locateToolStripMenuItem");
            // 
            // addLocToolStripMenuItem
            // 
            this.addLocToolStripMenuItem.Name = "addLocToolStripMenuItem";
            resources.ApplyResources(this.addLocToolStripMenuItem, "addLocToolStripMenuItem");
            this.addLocToolStripMenuItem.Click += new System.EventHandler(this.addLocToolStripMenuItem_Click);
            // 
            // delLocToolStripMenuItem
            // 
            this.delLocToolStripMenuItem.Name = "delLocToolStripMenuItem";
            resources.ApplyResources(this.delLocToolStripMenuItem, "delLocToolStripMenuItem");
            // 
            // openLocExplorerToolStripMenuItem
            // 
            this.openLocExplorerToolStripMenuItem.Name = "openLocExplorerToolStripMenuItem";
            resources.ApplyResources(this.openLocExplorerToolStripMenuItem, "openLocExplorerToolStripMenuItem");
            // 
            // openGameLocToolStripMenuItem
            // 
            this.openGameLocToolStripMenuItem.Name = "openGameLocToolStripMenuItem";
            resources.ApplyResources(this.openGameLocToolStripMenuItem, "openGameLocToolStripMenuItem");
            // 
            // delChoseVerToolStripMenuItem
            // 
            this.delChoseVerToolStripMenuItem.Name = "delChoseVerToolStripMenuItem";
            resources.ApplyResources(this.delChoseVerToolStripMenuItem, "delChoseVerToolStripMenuItem");
            // 
            // locBox
            // 
            this.locBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locBox.FormattingEnabled = true;
            resources.ApplyResources(this.locBox, "locBox");
            this.locBox.Name = "locBox";
            // 
            // lstManage
            // 
            this.lstManage.HideSelection = false;
            resources.ApplyResources(this.lstManage, "lstManage");
            this.lstManage.Name = "lstManage";
            this.lstManage.UseCompatibleStateImageBehavior = false;
            this.lstManage.View = System.Windows.Forms.View.Details;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.labAccCa);
            this.tabAccount.Controls.Add(this.btnAccMore);
            this.tabAccount.Controls.Add(this.accountNameBox);
            this.tabAccount.Controls.Add(this.gbAccountCreate);
            this.tabAccount.Controls.Add(this.picAvcAccount);
            resources.ApplyResources(this.tabAccount, "tabAccount");
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // labAccCa
            // 
            resources.ApplyResources(this.labAccCa, "labAccCa");
            this.labAccCa.Name = "labAccCa";
            // 
            // btnAccMore
            // 
            resources.ApplyResources(this.btnAccMore, "btnAccMore");
            this.btnAccMore.Name = "btnAccMore";
            this.btnAccMore.UseVisualStyleBackColor = true;
            this.btnAccMore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAccMore_MouseClick);
            // 
            // accountNameBox
            // 
            this.accountNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNameBox.FormattingEnabled = true;
            resources.ApplyResources(this.accountNameBox, "accountNameBox");
            this.accountNameBox.Name = "accountNameBox";
            // 
            // gbAccountCreate
            // 
            this.gbAccountCreate.Controls.Add(this.btnAddAccount);
            this.gbAccountCreate.Controls.Add(this.btnMSAcountLogin);
            this.gbAccountCreate.Controls.Add(this.labPlayerName);
            this.gbAccountCreate.Controls.Add(this.tbPlayerName);
            this.gbAccountCreate.Controls.Add(this.accTyCBox);
            resources.ApplyResources(this.gbAccountCreate, "gbAccountCreate");
            this.gbAccountCreate.Name = "gbAccountCreate";
            this.gbAccountCreate.TabStop = false;
            // 
            // btnAddAccount
            // 
            resources.ApplyResources(this.btnAddAccount, "btnAddAccount");
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnMSAcountLogin
            // 
            resources.ApplyResources(this.btnMSAcountLogin, "btnMSAcountLogin");
            this.btnMSAcountLogin.Name = "btnMSAcountLogin";
            this.btnMSAcountLogin.UseVisualStyleBackColor = true;
            this.btnMSAcountLogin.Click += new System.EventHandler(this.btnMSAcountLogin_Click);
            // 
            // labPlayerName
            // 
            resources.ApplyResources(this.labPlayerName, "labPlayerName");
            this.labPlayerName.Name = "labPlayerName";
            // 
            // tbPlayerName
            // 
            resources.ApplyResources(this.tbPlayerName, "tbPlayerName");
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.TextChanged += new System.EventHandler(this.tbPlayerName_TextChanged);
            // 
            // accTyCBox
            // 
            this.accTyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accTyCBox.FormattingEnabled = true;
            this.accTyCBox.Items.AddRange(new object[] {
            resources.GetString("accTyCBox.Items"),
            resources.GetString("accTyCBox.Items1")});
            resources.ApplyResources(this.accTyCBox, "accTyCBox");
            this.accTyCBox.Name = "accTyCBox";
            this.accTyCBox.SelectedIndexChanged += new System.EventHandler(this.accTyCBox_SelectedIndexChanged);
            // 
            // picAvcAccount
            // 
            resources.ApplyResources(this.picAvcAccount, "picAvcAccount");
            this.picAvcAccount.Name = "picAvcAccount";
            this.picAvcAccount.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabSetJava);
            this.tabControl1.Controls.Add(this.tabSetMemory);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabSetJava
            // 
            this.tabSetJava.Controls.Add(this.btnAutoCheckJava);
            this.tabSetJava.Controls.Add(this.gbJavaEdit);
            this.tabSetJava.Controls.Add(this.labJavaPath);
            this.tabSetJava.Controls.Add(this.javaPathBox);
            resources.ApplyResources(this.tabSetJava, "tabSetJava");
            this.tabSetJava.Name = "tabSetJava";
            this.tabSetJava.UseVisualStyleBackColor = true;
            // 
            // btnAutoCheckJava
            // 
            resources.ApplyResources(this.btnAutoCheckJava, "btnAutoCheckJava");
            this.btnAutoCheckJava.Name = "btnAutoCheckJava";
            this.btnAutoCheckJava.UseVisualStyleBackColor = true;
            // 
            // gbJavaEdit
            // 
            this.gbJavaEdit.Controls.Add(this.btnJavaChooseLoc);
            this.gbJavaEdit.Controls.Add(this.labJavaFolderLoc);
            this.gbJavaEdit.Controls.Add(this.tbJavaFolderLoc);
            this.gbJavaEdit.Controls.Add(this.btnAddEditJava);
            this.gbJavaEdit.Controls.Add(this.chbEditOrAdd);
            resources.ApplyResources(this.gbJavaEdit, "gbJavaEdit");
            this.gbJavaEdit.Name = "gbJavaEdit";
            this.gbJavaEdit.TabStop = false;
            // 
            // btnJavaChooseLoc
            // 
            resources.ApplyResources(this.btnJavaChooseLoc, "btnJavaChooseLoc");
            this.btnJavaChooseLoc.Name = "btnJavaChooseLoc";
            this.btnJavaChooseLoc.UseVisualStyleBackColor = true;
            this.btnJavaChooseLoc.Click += new System.EventHandler(this.btnJavaChooseLoc_Click);
            // 
            // labJavaFolderLoc
            // 
            resources.ApplyResources(this.labJavaFolderLoc, "labJavaFolderLoc");
            this.labJavaFolderLoc.Name = "labJavaFolderLoc";
            // 
            // tbJavaFolderLoc
            // 
            resources.ApplyResources(this.tbJavaFolderLoc, "tbJavaFolderLoc");
            this.tbJavaFolderLoc.Name = "tbJavaFolderLoc";
            this.tbJavaFolderLoc.ReadOnly = true;
            this.tbJavaFolderLoc.TextChanged += new System.EventHandler(this.tbJavaFolderLoc_TextChanged);
            // 
            // btnAddEditJava
            // 
            resources.ApplyResources(this.btnAddEditJava, "btnAddEditJava");
            this.btnAddEditJava.Name = "btnAddEditJava";
            this.btnAddEditJava.UseVisualStyleBackColor = true;
            // 
            // chbEditOrAdd
            // 
            resources.ApplyResources(this.chbEditOrAdd, "chbEditOrAdd");
            this.chbEditOrAdd.Name = "chbEditOrAdd";
            this.chbEditOrAdd.UseVisualStyleBackColor = true;
            this.chbEditOrAdd.CheckedChanged += new System.EventHandler(this.chbEditOrAdd_CheckedChanged);
            // 
            // labJavaPath
            // 
            resources.ApplyResources(this.labJavaPath, "labJavaPath");
            this.labJavaPath.Name = "labJavaPath";
            // 
            // javaPathBox
            // 
            this.javaPathBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.javaPathBox.FormattingEnabled = true;
            resources.ApplyResources(this.javaPathBox, "javaPathBox");
            this.javaPathBox.Name = "javaPathBox";
            // 
            // tabSetMemory
            // 
            this.tabSetMemory.Controls.Add(this.gbMemorySet);
            resources.ApplyResources(this.tabSetMemory, "tabSetMemory");
            this.tabSetMemory.Name = "tabSetMemory";
            this.tabSetMemory.UseVisualStyleBackColor = true;
            // 
            // gbMemorySet
            // 
            this.gbMemorySet.Controls.Add(this.labMaxAva);
            this.gbMemorySet.Controls.Add(this.labMaxMemoryMB);
            this.gbMemorySet.Controls.Add(this.nudMaxMemory);
            this.gbMemorySet.Controls.Add(this.labMaxMemory);
            resources.ApplyResources(this.gbMemorySet, "gbMemorySet");
            this.gbMemorySet.Name = "gbMemorySet";
            this.gbMemorySet.TabStop = false;
            // 
            // labMaxMemoryMB
            // 
            resources.ApplyResources(this.labMaxMemoryMB, "labMaxMemoryMB");
            this.labMaxMemoryMB.Name = "labMaxMemoryMB";
            // 
            // nudMaxMemory
            // 
            resources.ApplyResources(this.nudMaxMemory, "nudMaxMemory");
            this.nudMaxMemory.Name = "nudMaxMemory";
            // 
            // labMaxMemory
            // 
            resources.ApplyResources(this.labMaxMemory, "labMaxMemory");
            this.labMaxMemory.Name = "labMaxMemory";
            // 
            // cMemuAccMore
            // 
            this.cMemuAccMore.DropShadowEnabled = false;
            this.cMemuAccMore.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cMemuAccMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delAccountToolStripMenuItem,
            this.更改用户名ToolStripMenuItem});
            this.cMemuAccMore.Name = "cMemuAccMore";
            this.cMemuAccMore.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            resources.ApplyResources(this.cMemuAccMore, "cMemuAccMore");
            // 
            // delAccountToolStripMenuItem
            // 
            this.delAccountToolStripMenuItem.Name = "delAccountToolStripMenuItem";
            resources.ApplyResources(this.delAccountToolStripMenuItem, "delAccountToolStripMenuItem");
            // 
            // 更改用户名ToolStripMenuItem
            // 
            this.更改用户名ToolStripMenuItem.Name = "更改用户名ToolStripMenuItem";
            resources.ApplyResources(this.更改用户名ToolStripMenuItem, "更改用户名ToolStripMenuItem");
            // 
            // labMaxAva
            // 
            resources.ApplyResources(this.labMaxAva, "labMaxAva");
            this.labMaxAva.Name = "labMaxAva";
            // 
            // timerMemory
            // 
            this.timerMemory.Interval = 10000;
            this.timerMemory.Tick += new System.EventHandler(this.timerMemory_Tick);
            // 
            // WndMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WndMain";
            this.Opacity = 0.98D;
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvc)).EndInit();
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.tabVersion.ResumeLayout(false);
            this.cMemuAction.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.gbAccountCreate.ResumeLayout(false);
            this.gbAccountCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvcAccount)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSetJava.ResumeLayout(false);
            this.tabSetJava.PerformLayout();
            this.gbJavaEdit.ResumeLayout(false);
            this.gbJavaEdit.PerformLayout();
            this.tabSetMemory.ResumeLayout(false);
            this.gbMemorySet.ResumeLayout(false);
            this.gbMemorySet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMemory)).EndInit();
            this.cMemuAccMore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TabPage tabVersion;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ComboBox versionBox;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label labVerChoose;
        private System.Windows.Forms.PictureBox picAvc;
        private System.Windows.Forms.Button btnAccountManage;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.ComboBox accountBox;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.ComboBox editionBox;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.ComboBox sourceBox;
        private System.Windows.Forms.Label labSource;
        private System.Windows.Forms.ListView lstDownMan;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar pbarDownload;
        private System.Windows.Forms.ListView lstManage;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox locBox;
        private System.Windows.Forms.ContextMenuStrip cMemuAction;
        private System.Windows.Forms.ToolStripMenuItem locateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameLocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delLocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLocExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delChoseVerToolStripMenuItem;
        private System.Windows.Forms.PictureBox picAvcAccount;
        private System.Windows.Forms.GroupBox gbAccountCreate;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnMSAcountLogin;
        private System.Windows.Forms.Label labPlayerName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.ComboBox accTyCBox;
        private System.Windows.Forms.Label labAccCa;
        private System.Windows.Forms.Button btnAccMore;
        private System.Windows.Forms.ComboBox accountNameBox;
        private System.Windows.Forms.ContextMenuStrip cMemuAccMore;
        private System.Windows.Forms.ToolStripMenuItem delAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改用户名ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSetJava;
        private System.Windows.Forms.TabPage tabSetMemory;
        private System.Windows.Forms.GroupBox gbJavaEdit;
        private System.Windows.Forms.Label labJavaPath;
        private System.Windows.Forms.ComboBox javaPathBox;
        private System.Windows.Forms.Button btnAutoCheckJava;
        private System.Windows.Forms.Button btnJavaChooseLoc;
        private System.Windows.Forms.Label labJavaFolderLoc;
        private System.Windows.Forms.TextBox tbJavaFolderLoc;
        private System.Windows.Forms.Button btnAddEditJava;
        private System.Windows.Forms.CheckBox chbEditOrAdd;
        private System.Windows.Forms.GroupBox gbMemorySet;
        private System.Windows.Forms.Label labMaxMemory;
        private System.Windows.Forms.Label labMaxMemoryMB;
        private System.Windows.Forms.NumericUpDown nudMaxMemory;
        private System.Windows.Forms.Label labMaxAva;
        private System.Windows.Forms.Timer timerMemory;
    }
}

