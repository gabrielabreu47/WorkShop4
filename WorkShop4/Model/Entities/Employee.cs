using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Model.Enums;

namespace WorkShop4.Model.Entities
{
    public class Employee : BaseEntity
    {
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public EmployeeStatuses Status { get; set; }
        public int? PersonId { get; set; }
        public int BossId { get; set; }
        public virtual Boss Boss { get; set; }
    }
}
