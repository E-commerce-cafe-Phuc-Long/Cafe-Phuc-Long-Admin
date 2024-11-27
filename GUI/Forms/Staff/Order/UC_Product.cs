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
namespace GUI.Forms.Staff
{
    public partial class UC_Product : UserControl
    {
        private SanPham _product;
        public UC_Product(SanPham product)
        {
            this._product = product;
            InitializeComponent();
            this.Load += UC_Product_Load;
        }

        private void UC_Product_Load(object sender, EventArgs e)
        {
            label_productName.Text = _product.tenSP;
            CenterLabelHorizontally(label_productName, this);
        }
        private void CenterLabelHorizontally(Label label, UserControl userControl)
        {
            int x = (userControl.Width - label.Width) / 2;
            label.Location = new Point(x, label.Location.Y);

        }
    }
}
