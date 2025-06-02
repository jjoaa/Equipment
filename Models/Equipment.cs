using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime AcquiredDate { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }

        //public string? Type { get; set; } // 예: "소화기", "포병"
        //public string? Caliber { get; set; } // 구경

        public List<MaintenanceHistory> MaintenanceHistories { get; set; } = new();
    }


}
