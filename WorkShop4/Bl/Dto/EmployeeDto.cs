using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Model.Enums;

namespace WorkShop4.Bl.Dto
{
    public class EmployeeDto
    {
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public EmployeeStatuses Status { get; set; }
        public int PersonId { get; set; }
        public int BossId { get; set; }
        public PersonDto Person { get; set; }
        public BossDto Boss { get; set; }
    }
}
