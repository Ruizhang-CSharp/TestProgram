
namespace STMS.STMSApp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new STMS.STMSApp.UControls.UCircleButton();
            this.uPanel2 = new STMS.STMSApp.UControls.UPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUPwd = new System.Windows.Forms.TextBox();
            this.uPanel1 = new STMS.STMSApp.UControls.UPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.uPanel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::STMS.STMSApp.Properties.Resources.loginbgin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.uPanel2);
            this.panel1.Controls.Add(this.uPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(128, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 342);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BgColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.BgColor2 = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(112)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLogin.Location = new System.Drawing.Point(78, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 5;
            this.btnLogin.Size = new System.Drawing.Size(554, 47);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登 录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // uPanel2
            // 
            this.uPanel2.BgColor = System.Drawing.Color.Transparent;
            this.uPanel2.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.uPanel2.BorderWidth = 1;
            this.uPanel2.Controls.Add(this.label4);
            this.uPanel2.Controls.Add(this.txtUPwd);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(78, 194);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 5;
            this.uPanel2.Size = new System.Drawing.Size(554, 52);
            this.uPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // txtUPwd
            // 
            this.txtUPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(106)))));
            this.txtUPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtUPwd.ForeColor = System.Drawing.Color.White;
            this.txtUPwd.Location = new System.Drawing.Point(74, 8);
            this.txtUPwd.Name = "txtUPwd";
            this.txtUPwd.PasswordChar = '*';
            this.txtUPwd.Size = new System.Drawing.Size(463, 34);
            this.txtUPwd.TabIndex = 4;
            // 
            // uPanel1
            // 
            this.uPanel1.BgColor = System.Drawing.Color.Transparent;
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.uPanel1.BorderWidth = 1;
            this.uPanel1.Controls.Add(this.label2);
            this.uPanel1.Controls.Add(this.txtUName);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(78, 125);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 5;
            this.uPanel1.Size = new System.Drawing.Size(554, 52);
            this.uPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号：";
            // 
            // txtUName
            // 
            this.txtUName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(106)))));
            this.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUName.ForeColor = System.Drawing.Color.White;
            this.txtUName.Location = new System.Drawing.Point(72, 9);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(465, 34);
            this.txtUName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库温度监控系统";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STMS.STMSApp.Properties.Resources.logbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 607);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "仓库温度监控系统登录界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private UControls.UPanel uPanel1;
        private UControls.UCircleButton btnLogin;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUName;
    }
}

