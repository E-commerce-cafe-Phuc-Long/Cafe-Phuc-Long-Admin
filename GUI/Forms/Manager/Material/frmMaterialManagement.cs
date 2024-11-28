using BLL.Services.Category;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Size;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services.Recipe_material;
using BLL.Services.Material;
using DTO;

namespace GUI.Forms.Manager

{
    public partial class frmMaterialManagement : Form
    {
        private readonly IRecipeService _recipeService;
        private readonly IRecipe_materialService _recipe_materialService;
        private readonly IMaterialService _materialService;


        public frmMaterialManagement(
            IRecipeService recipeService,
            IRecipe_materialService recipe_materialService,
            IMaterialService materialService
            )
        {
            this._recipeService = recipeService;
            this._recipe_materialService = recipe_materialService;
            this._materialService = materialService;
            InitializeComponent();
            this.Load += FrmMaterialManagement_Load; ;
        }

        private void FrmMaterialManagement_Load(object sender, EventArgs e)
        {
            listView_RecipesList_Config();
            listView_Recipe_materialsList_Config();
            listView_materialsList_Config();
            LoadRecipesToListView();
            LoadmaterialsToListView();
            loadDataComboBox();
        }
        private void listView_RecipesList_Config()
        {
            listView_recipeList.View = View.Details;
            listView_recipeList.FullRowSelect = true;
            listView_recipeList.GridLines = true;
            listView_recipeList.MultiSelect = false;
            listView_recipeList.Items.Clear();
            listView_recipeList.Columns.Add("Mã công thức", 100);
            listView_recipeList.Columns.Add("Tên công thức", 200);
            listView_recipeList.Columns.Add("Mô tả", 250);
        }
        private void LoadRecipesToListView()
        {
            listView_recipeList.Items.Clear();
            var recipes = _recipeService.GetRecipeList();

            foreach (var recipe in recipes)
            {
                ListViewItem item = new ListViewItem(recipe.maCT);
                item.SubItems.Add(recipe.tenCT);
                item.SubItems.Add(recipe.moTa);
                item.Tag = recipe;

                listView_recipeList.Items.Add(item);
            }

        }

        private void listView_Recipe_materialsList_Config()
        {
            listView_recipe_materialsList.View = View.Details;
            listView_recipe_materialsList.FullRowSelect = true;
            listView_recipe_materialsList.GridLines = true;
            listView_recipe_materialsList.MultiSelect = false;
            listView_recipe_materialsList.Items.Clear();
            listView_recipe_materialsList.Columns.Add("Mã công thức", 100);
            listView_recipe_materialsList.Columns.Add("Mã Nguyên liệu", 100);
            listView_recipe_materialsList.Columns.Add("Số lượng", 100);
        }
        private void LoadRecipe_materialsToListView(List<CongThuc_NguyenLieu> recipe_materials)
        {
            listView_recipe_materialsList.Items.Clear();

            foreach (var recipe_material in recipe_materials)
            {
                ListViewItem item = new ListViewItem(recipe_material.maCT);
                item.SubItems.Add(recipe_material.maNL);
                item.SubItems.Add(recipe_material.soLuong.ToString());
                listView_recipe_materialsList.Items.Add(item);
            }

        }
        private void listView_materialsList_Config()
        {
            listView_materialsList.View = View.Details;
            listView_materialsList.FullRowSelect = true;
            listView_materialsList.GridLines = true;
            listView_materialsList.MultiSelect = false;
            listView_materialsList.Items.Clear();
            listView_materialsList.Columns.Add("Mã Nguyên liệu", 100);
            listView_materialsList.Columns.Add("Tên nguyên liệu", 150);
            listView_materialsList.Columns.Add("Số lượng", 100);
            listView_materialsList.Columns.Add("Đơn vị tính", 100);

        }
        private void LoadmaterialsToListView()
        {
            listView_materialsList.Items.Clear();
            var materials = _materialService.GetMaterialsList();

            foreach (var material in materials)
            {
                ListViewItem item = new ListViewItem(material.maNL);
                item.SubItems.Add(material.tenNL);
                item.SubItems.Add(material.soLuong.ToString());
                item.SubItems.Add(material.donViTinh);
                listView_materialsList.Items.Add(item);
            }

        }
       
        private void listView_recipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_recipeList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_recipeList.SelectedItems[0];
                string name = selectedItem.SubItems[1].Text;
                string recipeId = selectedItem.Text;
                string desc = selectedItem.SubItems[2].Text;
                if (recipeId == "")
                {

                    List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsList();
                    LoadRecipe_materialsToListView(ct_nt);
                }
                else
                {
                    txt_recipeName.Text = name;
                    txt_descRecipe.Text = desc;
                    List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsListById(recipeId, "");
                    LoadRecipe_materialsToListView(ct_nt);
                }
            }

        }

        private void listView_materialsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_materialsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_materialsList.SelectedItems[0];
                string name = selectedItem.SubItems[1].Text;
                string maNL = selectedItem.Text;
                string sl = selectedItem.SubItems[2].Text;
                string DVT = selectedItem.SubItems[3].Text;

                if (maNL == "")
                {

                    List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsList();
                    LoadRecipe_materialsToListView(ct_nt);
                }
                else
                {
                    txt_materialName.Text = name;
                    nud_soLuongMaterial.Value = int.Parse(sl);
                    comboBox_DVT.Text = DVT;
                    List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsListById("", maNL);
                    LoadRecipe_materialsToListView(ct_nt);
                }
            }
        }

        private void txt_DVT_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadDataComboBox()
        {
            var materials = _materialService.GetMaterialsList();
            comboBox_material.DataSource = materials;
            comboBox_material.DisplayMember = "tenNL";
            comboBox_material.ValueMember = "maNL";
            var recipes = _recipeService.GetRecipeList();
            comboBox_recipe.DataSource = recipes;
            comboBox_recipe.DisplayMember = "tenCT";
            comboBox_recipe.ValueMember = "maCT";
        }
        private void SelectInComboBox(string maCT, string maNL)
        {
            foreach (var item in comboBox_material.Items)
            {
                var nl = item as NguyenLieu;
                if (nl != null && nl.maNL == maNL)
                {
                    comboBox_material.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboBox_recipe.Items)
            {
                var recipe = item as CongThuc;
                if (recipe != null && recipe.maCT == maCT)
                {
                    comboBox_recipe.SelectedItem = item;
                    break;
                }
            }

        }
        private void listView_recipe_materialsList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView_recipe_materialsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_recipe_materialsList.SelectedItems[0];
                string recipeId = selectedItem.SubItems[0].Text;
                string materialId = selectedItem.SubItems[1].Text;
                string sl = selectedItem.SubItems[2].Text;
                SelectInComboBox(recipeId, materialId);
                nud_soLuongR_M.Value = int.Parse(sl);
            }

        }

        private void btn_addRecipe_Click(object sender, EventArgs e)
        {
            string recipeName = txt_recipeName.Text;
            string recipeDescription = txt_descRecipe.Text;
            if (recipeName == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
                return;
            }
            string maCT = _recipeService.GenerateRecipeCode();
            CongThuc ct = new CongThuc
            {
                maCT = maCT,
                tenCT = recipeName,
                moTa = recipeDescription
            };
            if (_recipeService.InsertRecipe(ct))
            {
                LoadRecipesToListView();
            }
            else
            {
                MessageBox.Show("Thêm công thức thất bại");
            }
        }

        private void btn_editRecipe_Click(object sender, EventArgs e)
        {
            if (listView_recipeList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn công thức cần sửa");
                return;
            }
            if (listView_recipeList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_recipeList.SelectedItems[0];
                string recipeId = selectedItem.Text;
                string recipeName = txt_recipeName.Text;
                string recipeDescription = txt_descRecipe.Text;
                if (recipeName == "")
                {
                    MessageBox.Show("Vui lòng nhập tên công thức");
                    return;
                }
                CongThuc ct = new CongThuc
                {
                    maCT = recipeId,
                    tenCT = recipeName,
                    moTa = recipeDescription
                };
                if (_recipeService.UpdateRecipe(ct))
                {
                    LoadRecipesToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật công thức thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công thức cần cập nhật");
            }
        }

        private void btn_deleteRecipe_Click(object sender, EventArgs e)
        {

            if (listView_recipeList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn công thức cần xóa");
                return;
            }
            if (listView_recipeList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_recipeList.SelectedItems[0];
                string recipeId = selectedItem.Text;
                if (_recipeService.DeleteRecipe(recipeId))
                {
                    LoadRecipesToListView();
                }
                else
                {
                    MessageBox.Show("Xóa công thức thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công thức cần xóa");
            }
        }

        private void btn_addMaterial_Click(object sender, EventArgs e)
        {

            string materialName = txt_materialName.Text;
            int soLuong = (int)nud_soLuongMaterial.Value;
            string DVT = comboBox_DVT.Text;
            if (materialName == "")
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu");
                return;
            }
            string maNL = _materialService.GenerateMaterialCode();
            NguyenLieu nl = new NguyenLieu
            {
                maNL = maNL,
                tenNL = materialName,
                soLuong = soLuong,
                donViTinh = DVT
            };
            if (_materialService.InsertMaterial(nl))
            {
                LoadmaterialsToListView();
            }
            else
            {
                MessageBox.Show("Thêm nguyên liệu thất bại");
            }
        }

        private void btn_editMaterial_Click(object sender, EventArgs e)
        {
            if (listView_materialsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần sửa");
                return;
            }
            if (listView_materialsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_materialsList.SelectedItems[0];
                string materialId = selectedItem.Text;
                string materialName = txt_materialName.Text;
                int soLuong = (int)nud_soLuongMaterial.Value;
                string DVT = comboBox_DVT.Text;
                if (materialName == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nguyên liệu");
                    return;
                }
                NguyenLieu nl = new NguyenLieu
                {
                    maNL = materialId,
                    tenNL = materialName,
                    soLuong = soLuong,
                    donViTinh = DVT
                };
                if (_materialService.UpdateMaterial(nl))
                {
                    LoadmaterialsToListView();
                }
                else
                {
                    MessageBox.Show("Cập nhật nguyên liệu thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần cập nhật");
            }
        }

        private void btn_deleteMaterial_Click(object sender, EventArgs e)
        {

            if (listView_materialsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa");
                return;
            }
            if (listView_materialsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_materialsList.SelectedItems[0];
                string materialId = selectedItem.Text;
                if (_materialService.DeleteMaterial(materialId))
                {
                    LoadmaterialsToListView();
                }
                else
                {
                    MessageBox.Show("Xóa nguyên liệu thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa");
            }
        }

        private void btn_searchCT_Click(object sender, EventArgs e)
        {
            string keyword = txt_searchCT.Text;
            if (keyword == "")
            {
                LoadRecipesToListView();
            }
            else
            {
                var recipes = _recipeService.SearchRecipe(keyword);
                listView_recipeList.Items.Clear();
                foreach (var recipe in recipes)
                {
                    ListViewItem item = new ListViewItem(recipe.maCT);
                    item.SubItems.Add(recipe.tenCT);
                    item.SubItems.Add(recipe.moTa);
                    item.Tag = recipe;

                    listView_recipeList.Items.Add(item);
                }
            }
        }

        private void btn_showAllCT_Click(object sender, EventArgs e)
        {
            LoadRecipesToListView();
        }

        private void btn_searchNL_Click(object sender, EventArgs e)
        {

            string keyword = txt_searchNL.Text;
            if (keyword == "")
            {
                LoadmaterialsToListView();
            }
            else
            {
                var materials = _materialService.SearchMaterial(keyword);
                listView_materialsList.Items.Clear();
                foreach (var material in materials)
                {
                    ListViewItem item = new ListViewItem(material.maNL);
                    item.SubItems.Add(material.tenNL);
                    item.SubItems.Add(material.soLuong.ToString());
                    item.SubItems.Add(material.donViTinh);
                    listView_materialsList.Items.Add(item);
                }
            }
        }

        private void btn_showAllNL_Click(object sender, EventArgs e)
        {
            LoadmaterialsToListView();
        }

        private void btn_addM_R_Click(object sender, EventArgs e)
        {
            string maCT = comboBox_recipe.SelectedValue.ToString();
            string maNL = comboBox_material.SelectedValue.ToString();
            int soLuong = (int)nud_soLuongR_M.Value;

            CongThuc_NguyenLieu ct_nl = _recipe_materialService.GetRecipe_materialsById(maCT, maNL);
            if (ct_nl != null)
            {
                MessageBox.Show("Nguyên liệu cho công thức này đã có rồi!");
                return;
            }
            CongThuc_NguyenLieu ctNL = new CongThuc_NguyenLieu
            {
                maCT = maCT,
                maNL = maNL,
                soLuong = soLuong
            };
            if (_recipe_materialService.InsertRecipe_material(ctNL))
            {
                List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsListById(maCT, "");
                LoadRecipe_materialsToListView(ct_nt);
            }
            else
            {
                MessageBox.Show("Thêm nguyên liệu vào công thức thất bại");
            }
        }

        private void btn_editM_R_Click(object sender, EventArgs e)
        {

            if (listView_recipe_materialsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần sửa");
                return;
            }
            if (listView_recipe_materialsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_recipe_materialsList.SelectedItems[0];
                string recipeId = selectedItem.SubItems[0].Text;
                string materialId = selectedItem.SubItems[1].Text;
                string sl = selectedItem.SubItems[2].Text;
                string maCT = comboBox_recipe.SelectedValue.ToString();
                string maNL = comboBox_material.SelectedValue.ToString();
                int soLuong = (int)nud_soLuongR_M.Value;
                CongThuc_NguyenLieu ct_nl = new CongThuc_NguyenLieu
                {
                    maCT = maCT,
                    maNL = maNL,
                    soLuong = soLuong
                };
                if (_recipe_materialService.UpdateRecipe_material(ct_nl))
                {
                    List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsListById(maCT, "");
                    LoadRecipe_materialsToListView(ct_nt);
                }
                else
                {
                    MessageBox.Show("Cập nhật nguyên liệu vào công thức thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần cập nhật");
            }
        }

        private void btn_deleteM_R_Click(object sender, EventArgs e)
        {

            if (listView_recipe_materialsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa");
                return;
            }
            if (listView_recipe_materialsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_recipe_materialsList.SelectedItems[0];
                string recipeId = selectedItem.SubItems[0].Text;
                string materialId = selectedItem.SubItems[1].Text;
                if (_recipe_materialService.DeleteRecipe_material(recipeId, materialId))
                {
                    List<CongThuc_NguyenLieu> ct_nt = _recipe_materialService.GetRecipe_materialsListById(recipeId, "");
                    LoadRecipe_materialsToListView(ct_nt);
                }
                else
                {
                    MessageBox.Show("Xóa nguyên liệu khỏi công thức thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa");
            }
        }
    }
}
