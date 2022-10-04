using System.ComponentModel.DataAnnotations;

namespace Week_5.Models
{
    public class Province
    {
        [Key, Required]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
