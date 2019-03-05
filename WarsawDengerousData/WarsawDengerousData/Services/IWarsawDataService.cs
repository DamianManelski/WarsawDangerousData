using System.Threading.Tasks;
using WarsawDengerousData.Services.DataModels;

namespace WarsawDengerousData.Services
{
    public interface IWarsawDataService
    {
        Task<WarsawData> GetIncydentForAsync(string districtName, string resourceId);
    }
}