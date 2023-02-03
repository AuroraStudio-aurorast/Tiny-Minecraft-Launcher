namespace TML
{
    partial class WndLogin
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
            this.wv2Login = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wv2Login)).BeginInit();
            this.SuspendLayout();
            // 
            // wv2Login
            // 
            this.wv2Login.AllowExternalDrop = true;
            this.wv2Login.CreationProperties = null;
            this.wv2Login.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv2Login.Location = new System.Drawing.Point(0, 0);
            this.wv2Login.Name = "wv2Login";
            this.wv2Login.Size = new System.Drawing.Size(551, 479);
            this.wv2Login.TabIndex = 0;
            this.wv2Login.ZoomFactor = 1D;
            // 
            // WndLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 479);
            this.Controls.Add(this.wv2Login);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WndLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.wv2Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv2Login;
    }
}