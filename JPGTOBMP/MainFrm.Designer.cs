namespace JPGTOBMP
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnReadBmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(26, 24);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(104, 32);
            this.btnOpenDir.TabIndex = 0;
            this.btnOpenDir.Text = "打开文件夹";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(165, 24);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(104, 32);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "转化";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnReadBmp
            // 
            this.btnReadBmp.Location = new System.Drawing.Point(12, 410);
            this.btnReadBmp.Name = "btnReadBmp";
            this.btnReadBmp.Size = new System.Drawing.Size(172, 32);
            this.btnReadBmp.TabIndex = 2;
            this.btnReadBmp.Text = "读取BMP像素数据";
            this.btnReadBmp.UseVisualStyleBackColor = true;
            this.btnReadBmp.Click += new System.EventHandler(this.btnReadBmp_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 454);
            this.Controls.Add(this.btnReadBmp);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnOpenDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "位图转换";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnReadBmp;
    }
}

