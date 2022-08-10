using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Services;

namespace Project_Template_SM22_Csharp.Views
{
    public partial class FrmSach : Form
    {
        SachService _sachService;
        public FrmSach()
        {
            InitializeComponent();
            _sachService = new SachService();
            LoadSoTrang();
            LoadSoTrangLoc();
            LoadSach(null);
        }

        public void LoadSoTrang()
        {
            for (int i = 0; i <= 200; i++)
            {
                cmb_SoTrang.Items.Add(i);
            }
            cmb_SoTrang.SelectedIndex = 0;
        }
        public void LoadSoTrangLoc()
        {
            foreach (var x in _sachService.GetSach())
            {
                cmb_Loc.Items.Add(x.SoTrang);
            }
            cmb_SoTrang.SelectedIndex = 0;
        }

        public void LoadSach(Sach s)
        {
            dgrid_Show.ColumnCount = 4;
            dgrid_Show.Columns[0].Name = "Mã";
            dgrid_Show.Columns[1].Name = "Tên";
            dgrid_Show.Columns[2].Name = "Số trang";
            dgrid_Show.Columns[3].Name = "Trạng thái";
            dgrid_Show.Rows.Clear();
            foreach (var x in _sachService.GetSach(s))
            {
                dgrid_Show.Rows.Add(x.Ma, x.Ten, x.SoTrang, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        public Sach GetValuesControl()
        {
            return new Sach()
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                SoTrang = Convert.ToInt32(cmb_SoTrang.Text),
                TrangThai = 1
            };
        }
        private void dgrid_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txt_Ma.Text = dgrid_Show.Rows[index].Cells[0].Value.ToString();
            txt_Ten.Text = dgrid_Show.Rows[index].Cells[1].Value.ToString();
            cmb_SoTrang.Text = dgrid_Show.Rows[index].Cells[2].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sachService.Add(GetValuesControl()));
            LoadSach(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sachService.Delete(GetValuesControl()));
            LoadSach(null);
        }

        private void cmb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sach = _sachService.GetSach().FirstOrDefault(p => p.SoTrang == int.Parse(cmb_Loc.Text));
            LoadSach(sach);
        }
    }
}
