using Microsoft.AspNetCore.Http;
using PlasticCompanyVersion2WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlasticCompany.Areas.Admin.Services.BannerServices
{
    public interface IBanner
    {
        Task<string> CreateBanner(int index, IFormFile file);

        List<Image> GetAll();

        Task<string> DeleteBanner(int index);
    }
}
