
using BeautySolun_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BeautySolun_API.Data
{
    public class DataBeautySalunContext:DbContext
    {
        public DataBeautySalunContext(DbContextOptions<DataBeautySalunContext> options) :base(options) 
        { 
        }

        public DbSet<TimeModel> bt_time { get; set; }

        public DbSet<StatusModel> bt_status { get; set; }


        public DbSet<ProfessionalModel> bt_professional { get; set; }

        public DbSet<ServiceModel> bt_service { get; set; }

        public DbSet<ScheduleModel> bt_schedule { get; set; }
    }
}
