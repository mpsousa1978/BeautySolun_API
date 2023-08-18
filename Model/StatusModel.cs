using System.ComponentModel.DataAnnotations;

namespace BeautySolun_API.Models
{
    public class StatusModel
    {
        [Key]
        public int Id_status { get; set; }
        public string Description { get; set; }
    }
}
