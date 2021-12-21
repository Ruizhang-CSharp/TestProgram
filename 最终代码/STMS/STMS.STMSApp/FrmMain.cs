using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STMS.STMSApp.UControls;

namespace STMS.STMSApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = null;
        int selModuleCode = 1;//1 store 2 product 3 temper
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if(this.Tag!=null)
            {
                InitStatusInfo();//状态栏信息初始化
                ShowStoreManage();//显示仓库管理页面
                btnClosePage.Visible = true;
                RegisterPageBtnClick();
                InitPageBtnTag();
            }
        }
        //设置分页按钮的Tag属性---页面关联
        private void InitPageBtnTag()
        {
            btnStorePage.Tag = typeof(store.FrmStoreList).FullName;//命名空间 +FrmStoreList
            btnSRegionPage.Tag = typeof(store.FrmStoreRegionList).FullName;
            btnProductPage.Tag = typeof(product.FrmProductList).FullName;
            btnProductInStorePage.Tag = typeof(product.FrmProductInStore).FullName;
            btnStoreTemperPage.Tag = typeof(storeTemper.FrmStoreRegionTemperatureList).FullName;
        }

        /// <summary>
        /// 注册分页按钮的单击事件
        /// </summary>
        private void RegisterPageBtnClick()
        {
             foreach(Control c in panelPageTop.Controls)
            {
                 if(c is UPageButton)
                {
                    UPageButton btn = c as UPageButton;
                    btn.Click += btnPage_Click;
                }
            }
        }

        /// <summary>
        /// 显示仓库管理页面
        /// </summary>
        private void ShowStoreManage()
        {
            SetModuleBtnBackColor(1);
            store.FrmStoreList fStoreList = new store.FrmStoreList();
            panelPage.AddPanelForm(fStoreList);
        }

        /// <summary>
        /// 状态栏信息初始化
        /// </summary>
        private void InitStatusInfo()
        {
            string uName = this.Tag.ToString();
            lblLoginUser.Text = uName;

            //时间  动态时间条--- 计时器  （Timers.Timer）
            lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }));
        }



       

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                    btnMax.Text = "1";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = "2";
            }
        }

        /// <summary>
        /// 关闭即退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "您确定要退出系统吗？") == DialogResult.Yes)
            {
                if(timer!=null)
                      timer.Stop();
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }

        /// <summary>
        /// 分页按钮单击处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPage_Click(object sender, EventArgs e)
        {
            //分页按钮文本颜色
            Color topSelColor = Color.FromArgb(45, 50, 116);//点击时或显示相关页面时
            Color topUnSelColor = Color.White;//默认或没有显示页面时

            UPageButton clickBtn = sender as UPageButton;//当前点击按钮

            foreach (Control c in panelPageTop.Controls)
            {
                if (c is UPageButton)
                {
                    UPageButton btn = c as UPageButton;
                    if (btn.Name != clickBtn.Name)
                    {
                        btn.ForeColor = topUnSelColor;
                    }
                }
               
            }
            //切换页面的实现
            if(clickBtn.Tag!=null)
            {
                string frmFullName = clickBtn.Tag.ToString();
                int lastIndex = frmFullName.LastIndexOf('.');
                string frmName = frmFullName.Substring(lastIndex + 1);
                Form f = FormUtility.GetOpenForm(frmName);
                if(f==null)
                {
                    //实例化
                    f = (Form)Activator.CreateInstance(Type.GetType(frmFullName));
                }
                panelPage.AddPanelForm(f);
                //是否处理关闭按钮的显示
                ShowClosePageBtn();
            }
        }

        /// <summary>
        /// 页面关闭按钮的显示
        /// </summary>
        private void ShowClosePageBtn()
        {
            if (panelPage.Controls.Count > 0)
                btnClosePage.Visible = true;
            else
                btnClosePage.Visible = false;
        }

        private void btnStoreManage_Click(object sender, EventArgs e)
        {
            ShowStoreManage();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            SetModuleBtnBackColor(2);
            product.FrmProductList fProductList = new product.FrmProductList();
            panelPage.AddPanelForm(fProductList);
        }

        private void btnStoreTemperManage_Click(object sender, EventArgs e)
        {
            SetModuleBtnBackColor(3);
            storeTemper.FrmStoreRegionTemperatureList fStoreTemperList = new storeTemper.FrmStoreRegionTemperatureList();
            panelPage.AddPanelForm(fStoreTemperList);
        }

        /// <summary>
        /// 设置模块按钮背景色
        /// </summary>
        /// <param name="code"></param>
        private void SetModuleBtnBackColor(int code)
        {
            switch(code)
            {
                case 1:
                    //设置仓库管理模块按钮的背景色，其他两个按钮背景---默认背景
                    SetMenuBtnsColor(btnStoreManage, btnStorePage);
                    break;
                case 2:
                    //设置产品管理模块按钮的背景色，其他两个按钮背景---默认背景
                    SetMenuBtnsColor(btnProductManage, btnProductPage);
                    break;
                case 3:
                    //设置仓库温控管理模块按钮的背景色，其他两个按钮背景---默认背景
                    SetMenuBtnsColor(btnStoreTemperManage, btnStoreTemperPage);
                    break;
            }
        }

        /// <summary>
        /// 处理左边按钮背景色和分页按钮的文本颜色
        /// </summary>
        private void SetMenuBtnsColor(UMenuButton btn,UPageButton btnPage)
        {
            //模块按钮的背景色
            Color unSelColor = Color.FromArgb(45, 50, 116);//未选中
            Color SelColor = Color.FromArgb(88, 116, 216);//选中
            //分页按钮文本颜色
            Color topSelColor = Color.FromArgb(45, 50, 116);//点击时或显示相关页面时
            Color topUnSelColor = Color.White;//默认或没有显示页面时

            btn.BackColor = SelColor;
            btnPage.ForeColor = topSelColor;

            //处理 未选中模块按钮、未显示 分页按钮
            UMenuButton[] menuBtns = { btnStoreManage, btnProductManage, btnStoreTemperManage };
            UPageButton[] pageBtns = { btnStorePage, btnSRegionPage, btnProductPage, btnProductInStorePage, btnStoreTemperPage };

            foreach(UMenuButton b in menuBtns)
            {
                if(b.Name!=btn.Name)
                {
                    b.BackColor = unSelColor;
                }
            }

            foreach(UPageButton b in pageBtns)
            {
                if(btnPage.Name!=b.Name)
                {
                    b.ForeColor = topUnSelColor;
                }
            }


        }

        Point point = new Point();
        bool isMove = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//按住的点
            isMove = true;

        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
             if(e.Button==MouseButtons.Left&&isMove)
            {
                Point pointNew = e.Location;//按住的点拖动到的位置
                Point fPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//相对于原来起点的距离点的描述
                this.Location += new Size(fPointNew);
            }
        }

        const int WM_NCHITTEST = 0x0084;// 移动鼠标
        const int HTLEFT = 10;
        const int HTRIGHT = 11;
        const int HTTOP = 12;
        const int HTTOPLEFT = 13;
        const int HTTOPRIGHT = 14;
        const int HTBOTTOM = 15;
        const int HTBOTTOMLEFT = 0x10;
        const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                        Point vPoint = new Point((int)m.LParam & 0xFFFF,
                       (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        if (vPoint.X <= 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else m.Result = (IntPtr)HTLEFT;
                        else if (vPoint.X >= ClientSize.Width - 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)HTTOPRIGHT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            else m.Result = (IntPtr)HTRIGHT;
                        else if (vPoint.Y <= 5)
                            m.Result = (IntPtr)HTTOP;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)HTBOTTOM;
                  
                        break;
            }
        }

        /// <summary>
        /// 面板中的页面尺寸与面板的尺寸同步---面板中Form页自适应处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPage_SizeChanged(object sender, EventArgs e)
        {
             foreach(Control c in panelPage.Controls)
            {
                Form f = c as Form;
                f.WindowState = FormWindowState.Normal;
                f.SuspendLayout();
                f.Size = panelPage.Size;
                //DataGridView 闪烁--- 先挂起  ，，，再恢复
                f.ResumeLayout();
                f.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// 页关闭处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClosePage_Click(object sender, EventArgs e)
        {
            if(panelPage.Controls.Count >0)
            {
                Form f = panelPage.Controls[0] as Form;
                f.Close();
                panelPage.Controls.Remove(f);
                //分页按钮的文本颜色
                foreach(Control c in panelPageTop.Controls)
                {
                    if(c is UPageButton)
                    {
                        UPageButton b = c as UPageButton;
                        if (b.Tag != null && b.Tag.ToString().Contains(f.Name))
                        {
                            b.ForeColor = Color.White;//重置为未选择状态
                            break;
                        }
                    }    
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("关闭页提示", "没有可关闭的页！");
                return;
            }
        }

      
    }
}
