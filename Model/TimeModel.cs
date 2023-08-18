using System.ComponentModel.DataAnnotations;

namespace BeautySolun_API.Models
{
    public class TimeModel
    {
        [Key]
        public int Id_time { get; set; }
        public string time_hhmm { get; set; }
        public int type { get; set; }
    }
}
