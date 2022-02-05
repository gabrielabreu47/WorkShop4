using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop4.Bl.Dto
{
    public class BossDto : BaseDto
    {
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
        public List<EmployeeDto> EmployeesAssigned { get; set; }
    }
}
