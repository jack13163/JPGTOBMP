using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPGTOBMP
{
    public partial class MainFrm : Form
    {
        private string path = "";
        private static int i = 0;

        public MainFrm()
        {
            InitializeComponent();
            this.btnTranslate.Enabled = false;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择JPG图片的最顶层文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    path = dialog.SelectedPath;
                    this.btnTranslate.Enabled = true;
                }
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;

            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //遍历文件夹下面的文件，将所有的JPG转换为BMP
            getDirectory(path);
            MessageBox.Show("转换成功");
        }

        /// <summary>
        /// 以递归的方式遍历指定了路径下的所有目录名
        /// </summary>
        /// <param name="path">父目录</param>
        public static void getDirectory(string path)
        {
            ChangeFormat(path);
            DirectoryInfo root = new DirectoryInfo(path);
            foreach (DirectoryInfo d in root.GetDirectories())
            {
                i = 0;
                getDirectory(d.FullName);
            }
        }

        /// <summary>
        /// 将指定目录下的所有文件夹中的文件转换为BMP位图，并保存到当前目录下
        /// </summary>
        /// <param name="path"></param>
        public static void ChangeFormat(string path)
        {
            DirectoryInfo root = new DirectoryInfo(path);
            foreach (FileInfo f in root.GetFiles())
            {
                Bitmap bmp = new Bitmap(path + "\\" + f.Name);
                Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppArgb);
                Graphics g = Graphics.FromImage(bmp2);
                g.DrawImage(bmp, 0, 0);
                bmp2.Save(path + "\\" + i + ".bmp", ImageFormat.Bmp);
                i++;
            }
        }

        private void btnReadBmp_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(@"H:\PICS\0.bmp");
            //for(int i = bmp.Height - 1; i >= 0; i--)
            //{
            //    for(int j = 0; j < bmp.Width; j++)
            //    {
            //        Console.Write("{0} ", bmp.GetPixel(j, i).R);
            //    }
            //}
        }
    }
}
