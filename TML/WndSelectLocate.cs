using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TML
{
    public partial class WndSelectLocate : Form
    {
        // WndSelcetLocate窗口初始化
        public WndSelectLocate()
        {
            InitializeComponent();
        }

        private void btnChooseLoc_Click(object sender, EventArgs e)
        {
            // 打开.minecraft文件夹
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users\\Documents";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // 过滤器
                var folderFilter = dialog.FileName;

                int whereFolder = folderFilter.IndexOf(".minecraft");
                int howLongLoc = dialog.FileName.Length;

                if (whereFolder != howLongLoc - 10)
                {
                    MessageBox.Show("请选择 .minecraft 文件夹！","错误");
                }
                else
                {
                    tbLocate.Text = dialog.FileName;
                }
            }
        }

        // 判断是否可解除“添加”的禁用
        private void canEnableAddBtn()
        {
            int tbLNLength = tbLocName.Text.Length;
            int tbLocLength = tbLocate.Text.Length;

            if (tbLNLength != 0 && tbLocLength != 0) 
            {
                this.btnAdd.Enabled = true;
            }
            else
            {
                this.btnAdd.Enabled = false;
            }
        }

        // 内容改变执行canEnableAddBtn
        private void tbLocName_TextChanged(object sender, EventArgs e)
        {
            canEnableAddBtn();
        }

        private void tbLocate_TextChanged(object sender, EventArgs e)
        {
            canEnableAddBtn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
