using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlasticCompany.Areas.Admin.Services.InformationServices
{
    public interface IInformation
    {
        Task<string> CreateAbout(string data, List<IFormFile> files);

        Task<string> CreateContact(string content);

        string GetContact();
    }
}
