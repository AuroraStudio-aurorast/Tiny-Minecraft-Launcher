using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Natsurainko.FluentCore.Model.Launch;
using Natsurainko.FluentCore.Module.Authenticator;
using Natsurainko.FluentCore.Module.Launcher;
using Natsurainko.FluentCore.Wrapper;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Management;

namespace TML
{
    public partial class WndMain : Form
    {
        // 定义值
        bool addOrEditJavaPath = false; // 若为添加，值为false

        // WMI传递可用内存
        public static long GetAvailablePhysicalMemory()
        {
            long capacity = 0;
            try
            {
                foreach (ManagementObject mo1 in new ManagementClass("Win32_PerfFormattedData_PerfOS_Memory").GetInstances())
                    capacity += long.Parse(mo1.Properties["AvailableBytes"].Value.ToString());
            }
            catch (Exception ex)
            {
                capacity = -1;
                Console.WriteLine(ex.Message);
            }
            return capacity;
        }

        // WndMain窗口初始化
        public WndMain()
        {
            // 基本初始化
            InitializeComponent();

            // 初始化选项
            this.sourceBox.SelectedIndex = 1;
            this.editionBox.SelectedIndex = 0;
            this.accTyCBox.SelectedIndex = 0;

            // 初始化下载列表
            this.lstDownMan.Columns.Add("版本", 100, HorizontalAlignment.Left);
            this.lstDownMan.Columns.Add("类型", 100, HorizontalAlignment.Left);
            this.lstDownMan.Columns.Add("日期", 120, HorizontalAlignment.Left);

            // 初始化管理列表
            this.lstManage.Columns.Add("版本", 100, HorizontalAlignment.Left);
            this.lstManage.Columns.Add("类型", 100, HorizontalAlignment.Left);
            this.lstManage.Columns.Add("日期", 120, HorizontalAlignment.Left);

            // 定义内存项设置
            if (GetAvailablePhysicalMemory() != -1)
            {
                this.labMaxAva.Text = "可用内存：" + GetAvailablePhysicalMemory() / 1024 / 1024 + " MB";
                this.nudMaxMemory.Maximum = GetAvailablePhysicalMemory() / 1024 / 1024;
                this.nudMaxMemory.Value = GetAvailablePhysicalMemory() / 1024 / 1024 / 2;
                timerMemory.Start();
            }
            else
            {
                this.labMaxAva.Text = "无法获取可用内存";
                this.nudMaxMemory.Maximum = 2048;
                this.nudMaxMemory.Value = 2048;
            }
        }

        // 标题栏右键菜单
        #region fields
        private const int WM_SYSCOMMAND = 0X112;
        private const int MF_STRING = 0X0;
        private const int MF_SEPARATOR = 0X800;
        private enum SystemMenuItem : int // 定义标签
        {
            About,
            FeedBack,
        }
        #endregion

        #region GetSystemMenu
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        #endregion

        #region AppendMenu
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);
        #endregion

        #region InsertMenu
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);
        #endregion

        // 定义标签对应内容
        #region OnHandleCreated
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            var hSysMenu = GetSystemMenu(this.Handle, false);
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, String.Empty);
            AppendMenu(hSysMenu, MF_STRING, (int)SystemMenuItem.About, "关于");
            AppendMenu(hSysMenu, MF_STRING, (int)SystemMenuItem.FeedBack, "反馈");
        }
        #endregion

        // 菜单点击触发事件
        #region WndProc
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_SYSCOMMAND)
            {
                switch ((SystemMenuItem)m.WParam)
                {
                    case SystemMenuItem.About:
                        // 关于部分
                        TaskDialog td = new TaskDialog(); // TaskDialog定义
                        td.Caption = "关于"; // 窗口标题
                        td.InstructionText = "Tiny Minecraft Launcher"; // 主标题
                        td.Text = "版本：1.0.0\n" +
                            "由 AuroraStudio 发布\n" +
                            "本软件使用 MIT 协议开源\n" +
                            "本项目使用到了...\n" +
                            "      Microsoft.Web.Webview2\n" +
                            "      Natsurainko.FluentCore"; // 内容
                        td.FooterText = "⚠️注意，目前正处于早期开发阶段，可能会有很多小问题"; // 页脚
                        td.Show();
                        break;

                    case SystemMenuItem.FeedBack:
                        // 反馈部分
                        System.Diagnostics.Process.Start("http://aurorast.cn"); // 暂时内容
                        break;
                }
            }
        }
        #endregion

        // 主页按钮事件
        private void btnAccountManage_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[3];
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[2];
        }

        // "操作"菜单呼出
        private void btnAction_MouseClick(object sender, MouseEventArgs e)
        {
            cMemuAction.Show((Button)sender, new Point(e.X, e.Y));
        }

        // 账户"更多"菜单呼出
        private void btnAccMore_MouseClick(object sender, MouseEventArgs e)
        {
            cMemuAccMore.Show((Button)sender, new Point(e.X, e.Y));
        }

        // 登录选项隐藏显示
        private void accTyCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.accTyCBox.SelectedIndex == 1)
            {
                this.tbPlayerName.Visible = false;
                this.labPlayerName.Visible = false;
                this.btnAddAccount.Visible = false;
                this.btnMSAcountLogin.Visible = true;
            }
            else
            {
                this.tbPlayerName.Visible = true;
                this.labPlayerName.Visible = true;
                this.btnAddAccount.Visible = true;
                this.btnMSAcountLogin.Visible = false;
            }
        }

        // 加载WndSelectLocate
        private void addLocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WndSelectLocate f = new WndSelectLocate();
            f.Show(this);
        }

        // 加载WndLogin
        private void btnMSAcountLogin_Click(object sender, EventArgs e)
        {
            WndLogin f = new WndLogin();
            f.Show(this);
        }

        // 打开Java文件夹
        private void btnJavaChooseLoc_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users\\Documents";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tbJavaFolderLoc.Text = dialog.FileName;
            }
        }

        // chbEditOrAdd控制是否编辑Java
        private void chbEditOrAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbEditOrAdd.Checked == true)
            {
                this.addOrEditJavaPath = true;
                this.btnAddEditJava.Text = "修改选中项";
            }
            else
            {
                this.addOrEditJavaPath = false;
                this.btnAddEditJava.Text = "添加";
            }
        }

        // 如果内出现tbJavaFolderLoc有文本则解除btnAddEditJava禁用
        private void tbJavaFolderLoc_TextChanged(object sender, EventArgs e)
        {
            if (tbJavaFolderLoc.Text != "")
            {
                btnAddEditJava.Enabled = true;
            }
        }

        // 是否有用户名，有则解除btnAddAccount禁用
        private void tbPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (tbPlayerName.Text != "")
            {
                btnAddAccount.Enabled = true;
            }
        }

        // 自动更新可用内存
        private void timerMemory_Tick(object sender, EventArgs e)
        {
            this.labMaxAva.Text = "可用内存：" + GetAvailablePhysicalMemory() / 1024 / 1024 + " MB";
            this.nudMaxMemory.Maximum = GetAvailablePhysicalMemory() / 1024 / 1024;
        }
    }
}
