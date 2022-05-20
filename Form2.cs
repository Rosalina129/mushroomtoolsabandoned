using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mushroomtools
{
    public partial class Form2 : Form
    {
        //打开文件对话框
        public string OpenFileasLevel()
        {
            string strFileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SMBX Map Maker Project(*.smmp)|*.smmp,*.smpp|All Files|*.*";
            ofd.ValidateNames = true; // 验证用户输入是否是一个有效的Windows文件名
            ofd.CheckFileExists = true; //验证路径的有效性
            ofd.CheckPathExists = true;//验证路径的有效性
            if (ofd.ShowDialog() == DialogResult.OK) //用户点击确认按钮，发送确认消息
            {
                strFileName = ofd.FileName;//获取在文件对话框中选定的路径或者字符串
            }
            return strFileName;
        }
        // 来源 https://blog.csdn.net/huanglin529/article/details/80897826
        public Form2()
        {
            InitializeComponent();
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileasLevel();
        }
    }
}
