using BLL.Services.GoodsReceipt;
using BLL.Services.GoodsReceiptDetails;
using BLL.Services.Material;
using BLL.Services.Supplier;
using DAL.Repositories.Category.GoodsReceipt;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms.Manager.GoodsReceipt
{

    public partial class frmCreategoodsreceiptManagement : Form
    {
        private readonly IGoodsReceiptService _goodsreceiptService;
        private readonly IGoodsReceiptDetailsService _goodsreceiptdetailsService;
        private readonly ISupplierService _supplierService;
        private readonly IMaterialService _materialService;
        public frmCreategoodsreceiptManagement(IGoodsReceiptService goodsreceiptService, ISupplierService supplierService, IGoodsReceiptDetailsService goodsreceiptdetailsService, IMaterialService materialService)
        {
            this._goodsreceiptService = goodsreceiptService;
            this._supplierService = supplierService;
            this._goodsreceiptdetailsService = goodsreceiptdetailsService;
            this._materialService = materialService;
            InitializeComponent();
        }

        private void frmCreategoodsreceiptManagement_Load(object sender, EventArgs e)
        {
            dtp_ngayNhap.Format = DateTimePickerFormat.Custom;
            dtp_ngayNhap.CustomFormat = "dd/MM/yy"; 
            txt_maPhieuNhap.Enabled = false;
            LoadSupplierToComboBox();
            LoadMaterialToComboBox();
            LoadSToDataGridView();
            CalculateTotalAmount();
            txt_soLuong.KeyPress += new KeyPressEventHandler(txt_soLuong_KeyPress);

            txt_donGia.KeyPress += new KeyPressEventHandler(txt_donGia_KeyPress);





        }

        private void LoadSToDataGridView()
        {

            string maPhieuNhap = txt_maPhieuNhap.Text;
            var details = _goodsreceiptdetailsService.GetDetailsByGoodsReceiptId(maPhieuNhap);

            dgv_taoPhieu.DataSource = details;

            dgv_taoPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_taoPhieu.Columns["tenNL"].HeaderText = "Tên Nguyên Liệu";
            dgv_taoPhieu.Columns["soLuongNhap"].HeaderText = "Số lượng";
            dgv_taoPhieu.Columns["donGia"].HeaderText = "Đơn giá";
            dgv_taoPhieu.Columns["thanhTien"].HeaderText = "Thành tiền";

            if (dgv_taoPhieu.Columns.Contains("maPhieuNhap"))
                dgv_taoPhieu.Columns["maPhieuNhap"].Visible = false;
            if (dgv_taoPhieu.Columns.Contains("maNL"))
                dgv_taoPhieu.Columns["maNL"].Visible = false;


        }




        private void LoadSupplierToComboBox()
        {
            var roles = _supplierService.GetSupplierList();
            comboBox_Supplier.DataSource = roles;
            comboBox_Supplier.DisplayMember = "tenNCC";
            comboBox_Supplier.ValueMember = "maNCC";
        }
        private void LoadMaterialToComboBox()
        {
            var a = _materialService.GetMaterialsList();
            comboBox_tenNL.DataSource = a;
            comboBox_tenNL.DisplayMember = "tenNL";
            comboBox_tenNL.ValueMember = "maNL";
        }

        private List<ChiTietPhieuNhap> tempDetails = new List<ChiTietPhieuNhap>();

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                string maNL = comboBox_tenNL.SelectedValue?.ToString();
                if (string.IsNullOrWhiteSpace(maNL))
                {
                    MessageBox.Show("Vui lòng chọn nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txt_soLuong.Text, out int soLuongNhap) || soLuongNhap <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_donGia.Text, out decimal donGia) || donGia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal thanhTien = soLuongNhap * donGia;

                // Kiểm tra nguyên liệu đã tồn tại trong danh sách tạm hay chưa
                var existingDetail = tempDetails.FirstOrDefault(d => d.maNL == maNL);
                if (existingDetail != null)
                {
                    // Cộng dồn số lượng và cập nhật thành tiền
                    existingDetail.soLuongNhap += soLuongNhap;
                    existingDetail.thanhTien = existingDetail.soLuongNhap * existingDetail.donGia;
                }
                else
                {
                    // Thêm mới vào danh sách tạm
                    ChiTietPhieuNhap detail = new ChiTietPhieuNhap
                    {
                        maNL = maNL,
                        soLuongNhap = soLuongNhap,
                        donGia = donGia,
                        thanhTien = thanhTien
                    };
                    tempDetails.Add(detail);
                }

                // Cập nhật lại DataGridView
                dgv_taoPhieu.DataSource = null;

                // Thay đổi DataSource để hiển thị tên nguyên liệu thay vì mã nguyên liệu
                dgv_taoPhieu.DataSource = tempDetails.Select(d => new
                {
                    tenNL = _materialService.GetMaterialNameById(d.maNL),
                    d.soLuongNhap,
                    d.donGia,
                    d.thanhTien
                }).ToList();

                dgv_taoPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_taoPhieu.Columns["tenNL"].HeaderText = "Tên Nguyên Liệu";
                dgv_taoPhieu.Columns["soLuongNhap"].HeaderText = "Số lượng";
                dgv_taoPhieu.Columns["donGia"].HeaderText = "Đơn giá";
                dgv_taoPhieu.Columns["thanhTien"].HeaderText = "Thành tiền";

                comboBox_Supplier.Enabled = false;

                CalculateTotalAmount();

                MessageBox.Show("Đã thêm nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset_BienTam();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CalculateThanhTien()
        {
            try
            {
                int soLuongNhap = 0;
                decimal donGia = 0;

                if (!string.IsNullOrWhiteSpace(txt_soLuong.Text) && int.TryParse(txt_soLuong.Text, out soLuongNhap) && soLuongNhap > 0)
                {
                    if (!string.IsNullOrWhiteSpace(txt_donGia.Text) && decimal.TryParse(txt_donGia.Text, out donGia) && donGia > 0)
                    {
                        decimal thanhTien = soLuongNhap * donGia;
                        txt_thanhTien.Text = thanhTien.ToString();
                    }
                    else
                    {
                        txt_thanhTien.Text = "0";
                    }
                }
                else
                {
                    txt_thanhTien.Text = "0";
                }
            }
            catch (Exception)
            {
                txt_thanhTien.Text = "0";
            }
        }

        private void CalculateTotalAmount()
        {
            try
            {
                decimal totalAmount = 0;

                foreach (DataGridViewRow row in dgv_taoPhieu.Rows)
                {
                    if (row.Cells["thanhTien"].Value != null)
                    {
                        totalAmount += Convert.ToDecimal(row.Cells["thanhTien"].Value);
                    }
                }

                txt_tongTien.Text = totalAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính tổng tiền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tempDetails.Any())
                {
                    MessageBox.Show("Danh sách phiếu nhập đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhieuNhap = txt_maPhieuNhap.Text.Trim();
                if (string.IsNullOrEmpty(maPhieuNhap))
                {
                    maPhieuNhap = _goodsreceiptService.GenerateCode();
                }

                string maNCC = comboBox_Supplier.SelectedValue?.ToString();
                if (string.IsNullOrWhiteSpace(maNCC))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayNhap = dtp_ngayNhap.Value;

                _goodsreceiptService.SaveGoodsReceipt(maPhieuNhap, maNCC, ngayNhap, tempDetails);


                MessageBox.Show("Phiếu nhập đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmGoodsReceiptManagement frm = new frmGoodsReceiptManagement(_goodsreceiptService, _supplierService, _goodsreceiptdetailsService, _materialService);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi lưu phiếu nhập: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tempDetails.Clear();
            CalculateTotalAmount();
            Reset_BienTam();
        }


        void Reset_BienTam()
        {
            comboBox_tenNL.SelectedIndex = -1;
            txt_soLuong.Text = string.Empty;
            txt_donGia.Text = string.Empty;
            txt_thanhTien.Text = string.Empty;
            comboBox_tenNL.Focus();
        }
     



        private void btn_drop_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn hủy tạo phiếu nhập?", "Xác nhận hủy",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Đóng form
                this.Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
                //try
                //{
                   
                //    var selectedRow = dgv_taoPhieu.SelectedRows[0];
                //    string maNL = selectedRow.Cells["tenNL"].Value.ToString();

                //    var selectedDetail = tempDetails.FirstOrDefault(d => _materialService.GetMaterialNameById(d.maNL) == maNL);

                //    if (selectedDetail != null)
                //    {
                //        if (!int.TryParse(txt_soLuong.Text, out int soLuongNhap) || soLuongNhap <= 0)
                //        {
                //            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            return;
                //        }

                //        if (!decimal.TryParse(txt_donGia.Text, out decimal donGia) || donGia <= 0)
                //        {
                //            MessageBox.Show("Vui lòng nhập đơn giá hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            return;
                //        }

                //        selectedDetail.soLuongNhap = soLuongNhap;
                //        selectedDetail.donGia = donGia;
                //        selectedDetail.thanhTien = soLuongNhap * donGia;

                //        // Cập nhật lại DataGridView để hiển thị thông tin đã thay đổi
                //        dgv_taoPhieu.DataSource = null;
                //        dgv_taoPhieu.DataSource = tempDetails.Select(d => new
                //        {
                //            TenNguyenLieu = _materialService.GetMaterialNameById(d.maNL),
                //            d.soLuongNhap,
                //            d.donGia,
                //            d.thanhTien
                //        }).ToList();

                //        dgv_taoPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //        dgv_taoPhieu.Columns["tenNL"].HeaderText = "Tên Nguyên Liệu";
                //        dgv_taoPhieu.Columns["soLuongNhap"].HeaderText = "Số lượng";
                //        dgv_taoPhieu.Columns["donGia"].HeaderText = "Đơn giá";
                //        dgv_taoPhieu.Columns["thanhTien"].HeaderText = "Thành tiền";

                //        CalculateTotalAmount();

                //        MessageBox.Show("Thông tin nguyên liệu đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        Reset_BienTam();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Không tìm thấy nguyên liệu trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Lỗi khi cập nhật nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_taoPhieu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một nguyên liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return; 
                }

                string selectedMaterialName = dgv_taoPhieu.SelectedRows[0].Cells["tenNL"].Value.ToString();

                var selectedDetail = tempDetails.FirstOrDefault(d => _materialService.GetMaterialNameById(d.maNL) == selectedMaterialName);

                if (selectedDetail != null)
                {
                   
                    tempDetails.Remove(selectedDetail);

 
                    dgv_taoPhieu.DataSource = null;

                    dgv_taoPhieu.DataSource = tempDetails.Select(d => new
                    {
                        TenNguyenLieu = _materialService.GetMaterialNameById(d.maNL),
                        d.soLuongNhap,
                        d.donGia,
                        d.thanhTien
                    }).ToList();

                    dgv_taoPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgv_taoPhieu.Columns["TenNguyenLieu"].HeaderText = "Tên Nguyên Liệu";
                    dgv_taoPhieu.Columns["soLuongNhap"].HeaderText = "Số lượng";
                    dgv_taoPhieu.Columns["donGia"].HeaderText = "Đơn giá";
                    dgv_taoPhieu.Columns["thanhTien"].HeaderText = "Thành tiền";

                    CalculateTotalAmount();

                    MessageBox.Show("Nguyên liệu đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset_BienTam();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nguyên liệu trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nguyên liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgv_taoPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (e.RowIndex >= 0)
                {
                    // Lấy thông tin từ dòng đã chọn
                    DataGridViewRow row = dgv_taoPhieu.Rows[e.RowIndex];

                    //comboBox_tenNL.SelectedItem = row.Cells["tenNL"].Value?.ToString();
                    txt_soLuong.Text = row.Cells["SoLuong"].Value?.ToString() ?? string.Empty;
                    txt_donGia.Text = row.Cells["DonGia"].Value?.ToString() ?? string.Empty;
                    txt_thanhTien.Text = row.Cells["thanhTien"].Value?.ToString() ?? string.Empty;


                }
            


        }
 
        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txt_donGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTienLocal();
        }

        private void txt_donGia_TextChanged(object sender, EventArgs e)
        {
            CalculateThanhTienLocal();
        }

      
        private void CalculateThanhTienLocal()
        {
            if (decimal.TryParse(txt_soLuong.Text, out decimal soLuong) &&
                decimal.TryParse(txt_donGia.Text, out decimal donGia))
            {
                decimal thanhTien = soLuong * donGia;
                txt_thanhTien.Text = thanhTien.ToString();
            }
            else
            {
                txt_thanhTien.Text = "0";
            }
        }
    }
}  




