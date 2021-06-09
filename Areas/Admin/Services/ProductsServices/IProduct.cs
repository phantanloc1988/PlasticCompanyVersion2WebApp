using Microsoft.AspNetCore.Http;
using PlasticCompanyVersion2WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlasticCompany.Areas.Admin.Services.ProductsServices
{
    public interface IProduct
    {
        Task<string> CreateProduct(Product data, List<IFormFile> files);

        Product GetProductById(int id);
        List<Product> GetAll();
    }
}
