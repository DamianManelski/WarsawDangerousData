using System.ComponentModel.DataAnnotations;

namespace WarsawDengerousData.Models
{
    public class UserData
    {
        [Required]
        [DataType(DataType.Password)]
        public string ApiKey { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string DistrictName { get; set; }
    }
}