
namespace STMS.STMSApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new STMS.STMSApp.UControls.UIconButton();
            this.btnMax = new STMS.STMSApp.UControls.UIconButton();
            this.btnMin = new STMS.STMSApp.UControls.UIconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageTop = new System.Windows.Forms.Panel();
            this.btnClosePage = new System.Windows.Forms.Button();
            this.btnStoreTemperPage = new STMS.STMSApp.UControls.UPageButton();
            this.btnProductInStorePage = new STMS.STMSApp.UControls.UPageButton();
            this.btnProductPage = new STMS.STMSApp.UControls.UPageButton();
            this.btnSRegionPage = new STMS.STMSApp.UControls.UPageButton();
            this.btnStorePage = new STMS.STMSApp.UControls.UPageButton();
            this.panelPage = new System.Windows.Forms.Panel();
            this.uPanel1 = new STMS.STMSApp.UControls.UPanel();
            this.btnStoreTemperManage = new STMS.STMSApp.UControls.UMenuButton();
            this.btnProductManage = new STMS.STMSApp.UControls.UMenuButton();
            this.btnStoreManage = new STMS.STMSApp.UControls.UMenuButton();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPageTop.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::STMS.STMSApp.Properties.Resources.logo;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1376, 89);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(1319, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "r";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnMax.ForeColor = System.Drawing.Color.Silver;
            this.btnMax.Location = new System.Drawing.Point(1270, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "1";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnMin.ForeColor = System.Drawing.Color.Silver;
            this.btnMin.Location = new System.Drawing.Point(1222, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "0";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.lblLoginTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblLoginUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(3, 739);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 59);
            this.panel2.TabIndex = 7;
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginTime.ForeColor = System.Drawing.Color.White;
            this.lblLoginTime.Location = new System.Drawing.Point(435, 14);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(0, 25);
            this.lblLoginTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(321, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "登录时间：";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.White;
            this.lblLoginUser.Location = new System.Drawing.Point(107, 14);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(0, 25);
            this.lblLoginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录者：";
            // 
            // panelPageTop
            // 
            this.panelPageTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPageTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panelPageTop.Controls.Add(this.btnClosePage);
            this.panelPageTop.Controls.Add(this.btnStoreTemperPage);
            this.panelPageTop.Controls.Add(this.btnProductInStorePage);
            this.panelPageTop.Controls.Add(this.btnProductPage);
            this.panelPageTop.Controls.Add(this.btnSRegionPage);
            this.panelPageTop.Controls.Add(this.btnStorePage);
            this.panelPageTop.Location = new System.Drawing.Point(312, 100);
            this.panelPageTop.Name = "panelPageTop";
            this.panelPageTop.Size = new System.Drawing.Size(1015, 40);
            this.panelPageTop.TabIndex = 8;
            // 
            // btnClosePage
            // 
            this.btnClosePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.btnClosePage.FlatAppearance.BorderSize = 0;
            this.btnClosePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePage.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosePage.ForeColor = System.Drawing.Color.White;
            this.btnClosePage.Location = new System.Drawing.Point(970, 0);
            this.btnClosePage.Name = "btnClosePage";
            this.btnClosePage.Size = new System.Drawing.Size(45, 40);
            this.btnClosePage.TabIndex = 2;
            this.btnClosePage.Text = "X";
            this.btnClosePage.UseVisualStyleBackColor = false;
            this.btnClosePage.Click += new System.EventHandler(this.btnClosePage_Click);
            // 
            // btnStoreTemperPage
            // 
            this.btnStoreTemperPage.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreTemperPage.BackgroundImage = global::STMS.STMSApp.Properties.Resources.btnbg05;
            this.btnStoreTemperPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStoreTemperPage.BtnText = "仓库温控页面";
            this.btnStoreTemperPage.Location = new System.Drawing.Point(773, 0);
            this.btnStoreTemperPage.Name = "btnStoreTemperPage";
            this.btnStoreTemperPage.Size = new System.Drawing.Size(165, 40);
            this.btnStoreTemperPage.TabIndex = 1;
            // 
            // btnProductInStorePage
            // 
            this.btnProductInStorePage.BackColor = System.Drawing.Color.Transparent;
            this.btnProductInStorePage.BackgroundImage = global::STMS.STMSApp.Properties.Resources.btnbg04;
            this.btnProductInStorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductInStorePage.BtnText = "产品入库页面";
            this.btnProductInStorePage.Location = new System.Drawing.Point(583, 0);
            this.btnProductInStorePage.Name = "btnProductInStorePage";
            this.btnProductInStorePage.Size = new System.Drawing.Size(165, 40);
            this.btnProductInStorePage.TabIndex = 1;
            // 
            // btnProductPage
            // 
            this.btnProductPage.BackColor = System.Drawing.Color.Transparent;
            this.btnProductPage.BackgroundImage = global::STMS.STMSApp.Properties.Resources.btnbg03;
            this.btnProductPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductPage.BtnText = "产品管理页面";
            this.btnProductPage.Location = new System.Drawing.Point(388, -1);
            this.btnProductPage.Name = "btnProductPage";
            this.btnProductPage.Size = new System.Drawing.Size(165, 40);
            this.btnProductPage.TabIndex = 1;
            // 
            // btnSRegionPage
            // 
            this.btnSRegionPage.BackColor = System.Drawing.Color.Transparent;
            this.btnSRegionPage.BackgroundImage = global::STMS.STMSApp.Properties.Resources.btnbg02;
            this.btnSRegionPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSRegionPage.BtnText = "仓库分区页面";
            this.btnSRegionPage.Location = new System.Drawing.Point(198, -1);
            this.btnSRegionPage.Name = "btnSRegionPage";
            this.btnSRegionPage.Size = new System.Drawing.Size(165, 40);
            this.btnSRegionPage.TabIndex = 1;
            // 
            // btnStorePage
            // 
            this.btnStorePage.BackColor = System.Drawing.Color.Transparent;
            this.btnStorePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStorePage.BackgroundImage")));
            this.btnStorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStorePage.BtnText = "仓库管理页面";
            this.btnStorePage.Location = new System.Drawing.Point(3, -1);
            this.btnStorePage.Name = "btnStorePage";
            this.btnStorePage.Size = new System.Drawing.Size(165, 40);
            this.btnStorePage.TabIndex = 0;
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.Location = new System.Drawing.Point(312, 157);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1015, 573);
            this.panelPage.TabIndex = 10;
            this.panelPage.SizeChanged += new System.EventHandler(this.panelPage_SizeChanged);
            // 
            // uPanel1
            // 
            this.uPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uPanel1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.Red;
            this.uPanel1.Controls.Add(this.btnStoreTemperManage);
            this.uPanel1.Controls.Add(this.btnProductManage);
            this.uPanel1.Controls.Add(this.btnStoreManage);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(8, 100);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 8;
            this.uPanel1.Size = new System.Drawing.Size(276, 630);
            this.uPanel1.TabIndex = 1;
            // 
            // btnStoreTemperManage
            // 
            this.btnStoreTemperManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreTemperManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnStoreTemperManage.BtnImg = global::STMS.STMSApp.Properties.Resources._04;
            this.btnStoreTemperManage.BtnText = "仓库温控管理";
            this.btnStoreTemperManage.Location = new System.Drawing.Point(1, 142);
            this.btnStoreTemperManage.Name = "btnStoreTemperManage";
            this.btnStoreTemperManage.Size = new System.Drawing.Size(274, 60);
            this.btnStoreTemperManage.TabIndex = 0;
            this.btnStoreTemperManage.Click += new System.EventHandler(this.btnStoreTemperManage_Click);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnProductManage.BtnImg = global::STMS.STMSApp.Properties.Resources._03;
            this.btnProductManage.BtnText = "产品管理";
            this.btnProductManage.Location = new System.Drawing.Point(1, 80);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(274, 60);
            this.btnProductManage.TabIndex = 0;
            this.btnProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // btnStoreManage
            // 
            this.btnStoreManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnStoreManage.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnStoreManage.BtnImg")));
            this.btnStoreManage.BtnText = "仓库管理";
            this.btnStoreManage.Location = new System.Drawing.Point(1, 18);
            this.btnStoreManage.Name = "btnStoreManage";
            this.btnStoreManage.Size = new System.Drawing.Size(274, 60);
            this.btnStoreManage.TabIndex = 0;
            this.btnStoreManage.Click += new System.EventHandler(this.btnStoreManage_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelPageTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uPanel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "仓库温控系统主页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPageTop.ResumeLayout(false);
            this.uPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPageTop;
        private System.Windows.Forms.Panel panelPage;
        private UControls.UMenuButton btnStoreManage;
        private UControls.UIconButton btnClose;
        private UControls.UIconButton btnMax;
        private UControls.UIconButton btnMin;
        private UControls.UPageButton btnStorePage;
        private UControls.UPageButton btnSRegionPage;
        private UControls.UPageButton btnStoreTemperPage;
        private UControls.UPageButton btnProductInStorePage;
        private UControls.UPageButton btnProductPage;
        private UControls.UMenuButton btnStoreTemperManage;
        private UControls.UMenuButton btnProductManage;
        private System.Windows.Forms.Button btnClosePage;
    }
}