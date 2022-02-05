using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop4.Bl.Dto
{
    public class PersonDto : BaseDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
