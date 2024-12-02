using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DAL.Repositories.Product;
using dotenv.net;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            this._repository = repository;
        }
        public List<SanPham> GetProductList()
        {
            return _repository.GetProductList();
        }
        public List<SanPham> GetProductByCategoryId(string categoryId)
        {
            return _repository.GetProductByCategoryId(categoryId);
        }
        public string UploadImage(string imageUrl)
        {
            // Đọc các biến môi trường từ file .env
            DotEnv.Load(options: new DotEnvOptions(probeForEnv: true));

            // Lấy thông tin Cloudinary từ biến môi trường
            var cloudinaryUrl = "cloudinary://633155845568885:smAcqf0SCiIiU9yzl6nBXXCZKaU@dgl1kzmgc";

            if (string.IsNullOrEmpty(cloudinaryUrl))
            {
                string message = "Cloudinary URL không được tìm thấy trong .env";
                return message;
            }

            // Khởi tạo Cloudinary với thông tin từ .env
            Cloudinary cloudinary = new Cloudinary(cloudinaryUrl);
            cloudinary.Api.Secure = true; // Cho phép các URL bảo mật khi upload

            // Thiết lập tham số upload
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imageUrl),
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true,
                Folder = "E-Commerce_Coffee_And_Tea",
            };
            try
            {
                // Upload ảnh lên Cloudinary
                var uploadResult = cloudinary.Upload(uploadParams);

                // Lấy URL ảnh từ kết quả trả về
                string imageUrlUploaded = uploadResult.SecureUrl.ToString();

                return imageUrlUploaded;
            }
            catch (Exception ex)
            {
                return "Đã xảy ra lỗi khi upload ảnh";
            }
        }
        public SanPham GetProductByName(string productName)
        {
            return _repository.GetProductByName(productName);
        }
        public List<SanPham> GetProductListByName(string productName)
        {
            return _repository.GetProductListByName(productName);
        }
        public bool InsertProduct(SanPham nv)
        {
            return _repository.InsertProduct(nv);
        }
        public bool DeleteProduct(string masp)
        {
            return _repository.DeleteProduct(masp);

        }
        public bool UpdateProduct(SanPham update)
        {
            return _repository.UpdateProduct(update);
        }
        public List<SanPham> SearchProduct(string keyword)
        {
            return _repository.SearchProduct(keyword);
        }
        public List<TrangThai_SP> trangThai_SPs()
        {
            return _repository.trangThai_SPs();
        }
        public string GenerateProductCode()
        {
            var lastProductCode = _repository.GetLastProductCode();

            if (string.IsNullOrEmpty(lastProductCode))
            {
                return "SP001";
            }

            var number = int.Parse(lastProductCode.Substring(2));

            return $"SP{(number + 1):D3}";
        }
    }
}