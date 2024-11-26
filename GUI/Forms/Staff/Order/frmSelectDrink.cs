using BLL.Services;
using BLL.Services.Dosage;
using BLL.Services.Size;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmSelectDrink : Form
    {
        private readonly IDosageService _dosage;
        private readonly ISizeService _sizeService;
        private string maSP;
        public frmSelectDrink(IDosageService dosage, ISizeService _sizeService,string maSP)
        {
            this._dosage = dosage;
            this._sizeService = _sizeService;
            this.maSP = maSP;
            InitializeComponent();
            this.Load += FrmSelectDrink_Load; ;   

        }
        private void FrmSelectDrink_Load(object sender, EventArgs e)
        {
            loadDataComboBox();
        }
        private void loadDataComboBox()
        {
            List<LieuLuong> lieuluongs = _dosage.GetAll();
            var list1 = new List<LieuLuong>(lieuluongs);
            var list2 = new List<LieuLuong>(lieuluongs);
            var list3 = new List<LieuLuong>(lieuluongs);
            comboBox_da.DataSource = list1;
            comboBox_da.DisplayMember = "tenLL";
            comboBox_da.ValueMember = "maLL";
            comboBox_duong.DataSource = list2;
            comboBox_duong.DisplayMember = "tenLL";
            comboBox_duong.ValueMember = "maLL";
            comboBox_tra.DataSource = list3;
            comboBox_tra.DisplayMember = "tenLL";
            comboBox_tra.ValueMember = "maLL";
            List<DTO.Size> sizes = _sizeService.GetSizesByProductId(maSP);
            comboBox_size.DataSource = sizes;
            comboBox_size.DisplayMember = "tenSize";
            comboBox_size.ValueMember = "maSize";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string da = comboBox_da.SelectedValue.ToString();
            string duong = comboBox_duong.SelectedValue.ToString();
            string tra = comboBox_tra.SelectedValue.ToString();
            string size = comboBox_size.SelectedValue.ToString();

            string sl = soluong.Value.ToString();

            // Truyền giá trị về form trước đó
            ((frmCreateOrderSaff)this.Owner).da = da;
            ((frmCreateOrderSaff)this.Owner).duong = duong;
            ((frmCreateOrderSaff)this.Owner).tra = tra;
            ((frmCreateOrderSaff)this.Owner).sl = sl;
            ((frmCreateOrderSaff)this.Owner).size = size;
            ((frmCreateOrderSaff)this.Owner).confirm = true;
            this.Close();
        }
    }
}
