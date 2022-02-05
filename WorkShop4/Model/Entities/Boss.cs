using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop4.Model.Entities
{
    public class Boss : BaseEntity
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Employee> EmployeesAssigned { get; set; }
    }
}
