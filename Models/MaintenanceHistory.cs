
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Models
{
    public class MaintenanceHistory
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Technician { get; set; }
        public string Description { get; set; }

        public DateTime? NextDueDate { get; set; } // 정기 점검일
    }
}
