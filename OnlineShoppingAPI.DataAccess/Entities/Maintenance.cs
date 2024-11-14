using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingAPI.DataAccess.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }
        public bool IsInMaintenance { get; set; }
        public DateTime? MaintenanceStartTime { get; set; }
        public DateTime? MaintenanceEndTime { get; set; }
    }
}
