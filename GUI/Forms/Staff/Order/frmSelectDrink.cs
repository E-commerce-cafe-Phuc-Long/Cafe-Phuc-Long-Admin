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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace GUI.Forms
{
    public partial class frmSelectDrink : Form
    {
        private readonly IDosageService _dosage;
        private readonly ISizeService _sizeService;
        private string maSP;
        private string size;
        private string da;
        private string duong;
        private string tra;
        private string sl;

        public frmSelectDrink(IDosageService dosage, ISizeService _sizeService, string maSP, string sl = null, string size = null, string da = null, string duong = null, string tra = null)
        {
            this._dosage = dosage;
            this._sizeService = _sizeService;
            this.maSP = maSP;
            this.size = size;
            this.da = da;
            this.duong = duong;
            this.tra = tra;
            this.sl = sl;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += FrmSelectDrink_Load;
        }
        private void FrmSelectDrink_Load(object sender, EventArgs e)
        {
            loadDataComboBox();
            if(da != null)
            {
                SelectComboBoxItem<DTO.Size>(size, comboBox_size, "maSize");
                SelectComboBoxItem<LieuLuong>(da, comboBox_da, "maLL");
                SelectComboBoxItem<LieuLuong>(duong, comboBox_duong, "maLL");
                SelectComboBoxItem<LieuLuong>(tra, comboBox_tra, "maLL");
                soluong.Value = Convert.ToInt32(sl);
            }
        }
        private void SetComboBoxDataSource<T>(ComboBox comboBox, List<T> dataList, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataList;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        private void loadDataComboBox()
        {
            List<LieuLuong> lieuluongs = _dosage.GetAll();
            var list1 = new List<LieuLuong>(lieuluongs);
            var list2 = new List<LieuLuong>(lieuluongs);
            var list3 = new List<LieuLuong>(lieuluongs);
            SetComboBoxDataSource(comboBox_da, list1, "tenLL", "maLL");
            SetComboBoxDataSource(comboBox_duong, list2, "tenLL", "maLL");
            SetComboBoxDataSource(comboBox_tra, list3, "tenLL", "maLL");
            List<DTO.Size> sizes = _sizeService.GetSizesByProductId(maSP);
            SetComboBoxDataSource(comboBox_size, sizes, "tenSize", "maSize");
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

        private void SelectComboBoxItem<T>(string inputString, ComboBox comboBox, string valueMember)
        {
            foreach (var item in comboBox.Items)
            {
                if (item is T obj)
                {
                    var propertyInfo = typeof(T).GetProperty(valueMember);
                    if (propertyInfo != null)
                    {
                        var value = propertyInfo.GetValue(obj)?.ToString();

                        if (value != null && value.Equals(inputString, StringComparison.OrdinalIgnoreCase))
                        {
                            comboBox.SelectedItem = obj; 
                            break; 
                        }
                    }
                }
                else if (item is string str) 
                {
                    if (str.Equals(inputString, StringComparison.OrdinalIgnoreCase))
                    {
                        comboBox.SelectedItem = str; 
                        break;
                    }
                }
            }
        }
        
    }
}
