using STMS.BLL;
using STMS.Models.DModels;
using STMS.STMSApp.FModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS.STMSApp
{
    public static class FormUtility
    {
        //静态类中的静态方法---扩展方法

        //检查一个Form是否已打开
        public static bool CheckOpenForm(string frmName)
        {
            bool bl = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmName)
                {
                    bl = true;
                    break;
                }
            }
            return bl;
        }

        //获取指定Name的Form
        public static Form GetOpenForm(string frmName)
        {
            Form frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frmName)
                {
                    frm = f;
                    break;
                }
            }
            return frm;
        }

        /// <summary>
        /// 将指定 的Form显示到Panel之中
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="frm"></param>
        public static void AddPanelForm(this Panel panel, Form frm)
        {
            bool bExist = false;
            //检查：Form是否已打开 
            if (CheckOpenForm(frm.Name))
            {
                Form f = GetOpenForm(frm.Name);
                //判断，当前显示的Form是否已经显示在Panel
                bool bl = false;
                foreach (Control c in panel.Controls)
                {
                    if (c is Form)
                    {
                        Form form = c as Form;
                        if (form.Name == f.Name)
                        {
                            frm = form;
                            bl = true;
                            bExist = true;
                            break;
                        }
                    }
                }
                if (!bl)
                {
                    frm = f;
                }
            }
            panel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            panel.Controls.Add(frm);
            frm.Show();

        }

        /// <summary>
        /// DataGridView 基本操作列的显示处理
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="isDel"></param>
        public static void ShowDgvCols(this DataGridView dgv, bool isDel)
        {
            dgv.Columns["colEdit"].Visible = !isDel;
            dgv.Columns["colDel"].Visible = !isDel;
            dgv.Columns["colRecover"].Visible = isDel;
            dgv.Columns["colRemove"].Visible = isDel;
        }

        /// <summary>
        /// 获取操作类型名（删除/恢复/移除）
        /// </summary>
        /// <param name="delCode"></param>
        /// <returns></returns>
        public static string GetDelName(int delCode)
        {
            string delName = "删除";
            switch (delCode)
            {
                case 1:delName = "删除";break;
                case 0: delName = "恢复"; break;
                case 2: delName = "移除"; break;
            }
            return delName;
        }

        /// <summary>
        /// 加载仓库下拉框
        /// </summary>
        /// <param name="cbo"></param>
        public static void LoadCboStores(ComboBox cbo)
        {
            StoreBLL storeBLL = new StoreBLL();
            List<StoreInfo> storeList = storeBLL.GetAllStores();
            storeList.Insert(0, new StoreInfo()
            {
                StoreId = 0,
                StoreName = "-----请选择-----"
            });
            cbo.DisplayMember = "StoreName";
            cbo.ValueMember = "StoreId";
            cbo.DataSource = storeList;
            cbo.SelectedIndex = 0;
        }

        /// <summary>
        /// 分区状态列表
        /// </summary>
        /// <returns></returns>
        public static List<RegionStateModel> RegionStateList()
        {
            return new List<RegionStateModel>()
            {
                new RegionStateModel(){RegionState =-1,StateText="全部"},
                new RegionStateModel(){RegionState =0,StateText="低温"},
                new RegionStateModel(){RegionState =1,StateText="正常"},
                new RegionStateModel(){RegionState =2,StateText="高温"}
            };
        }

    }
}
