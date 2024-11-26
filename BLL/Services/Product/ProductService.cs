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
            var cloudinaryUrl = Environment.GetEnvironmentVariable("CLOUDINARY_URL");

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
                Overwrite = true
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
    }
}