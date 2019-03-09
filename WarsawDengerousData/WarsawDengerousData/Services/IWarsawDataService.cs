using System.Threading.Tasks;
using WarsawDengerousData.Models;
using WarsawDengerousData.WarsawApiData;

namespace WarsawDengerousData.Services
{
    public interface IWarsawDataService
    {
        Task<WarsawData> GetIncydentForAsync(UserData userData, string resourceId);
    }
}