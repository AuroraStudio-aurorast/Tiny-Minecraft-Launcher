namespace TML
{
    partial class WndSelectLocate
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnChooseLoc = new System.Windows.Forms.Button();
            this.tbLocate = new System.Windows.Forms.TextBox();
            this.labLocate = new System.Windows.Forms.Label();
            this.tbLocName = new System.Windows.Forms.TextBox();
            this.labLocName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnChooseLoc);
            this.groupBox.Controls.Add(this.tbLocate);
            this.groupBox.Controls.Add(this.labLocate);
            this.groupBox.Controls.Add(this.tbLocName);
            this.groupBox.Controls.Add(this.labLocName);
            this.groupBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(387, 131);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "内容";
            // 
            // btnChooseLoc
            // 
            this.btnChooseLoc.Location = new System.Drawing.Point(319, 81);
            this.btnChooseLoc.Name = "btnChooseLoc";
            this.btnChooseLoc.Size = new System.Drawing.Size(52, 31);
            this.btnChooseLoc.TabIndex = 4;
            this.btnChooseLoc.Text = "...";
            this.btnChooseLoc.UseVisualStyleBackColor = true;
            this.btnChooseLoc.Click += new System.EventHandler(this.btnChooseLoc_Click);
            // 
            // tbLocate
            // 
            this.tbLocate.Location = new System.Drawing.Point(78, 81);
            this.tbLocate.Name = "tbLocate";
            this.tbLocate.ReadOnly = true;
            this.tbLocate.Size = new System.Drawing.Size(243, 31);
            this.tbLocate.TabIndex = 3;
            this.tbLocate.TextChanged += new System.EventHandler(this.tbLocate_TextChanged);
            // 
            // labLocate
            // 
            this.labLocate.AutoSize = true;
            this.labLocate.Location = new System.Drawing.Point(16, 84);
            this.labLocate.Name = "labLocate";
            this.labLocate.Size = new System.Drawing.Size(64, 24);
            this.labLocate.TabIndex = 2;
            this.labLocate.Text = "路径：";
            // 
            // tbLocName
            // 
            this.tbLocName.Location = new System.Drawing.Point(78, 30);
            this.tbLocName.Name = "tbLocName";
            this.tbLocName.Size = new System.Drawing.Size(293, 31);
            this.tbLocName.TabIndex = 1;
            this.tbLocName.TextChanged += new System.EventHandler(this.tbLocName_TextChanged);
            // 
            // labLocName
            // 
            this.labLocName.AutoSize = true;
            this.labLocName.Location = new System.Drawing.Point(16, 33);
            this.labLocName.Name = "labLocName";
            this.labLocName.Size = new System.Drawing.Size(64, 24);
            this.labLocName.TabIndex = 0;
            this.labLocName.Text = "名称：";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnAdd.Location = new System.Drawing.Point(261, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // WndSelectLocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 199);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WndSelectLocate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加位置";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChooseLoc;
        private System.Windows.Forms.TextBox tbLocate;
        private System.Windows.Forms.Label labLocate;
        private System.Windows.Forms.TextBox tbLocName;
        private System.Windows.Forms.Label labLocName;
    }
}