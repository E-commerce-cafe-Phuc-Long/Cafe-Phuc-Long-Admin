using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI.Forms
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
            SetImageFromUrl(pictureBox1, _product.hinhAnh);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void CenterLabelHorizontally(Label label, UserControl userControl)
        {
            int x = (userControl.Width - label.Width) / 2;
            label.Location = new Point(x, label.Location.Y);

        }
        private async void SetImageFromUrl(PictureBox pictureBox, string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(url);

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
