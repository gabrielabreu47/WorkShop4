using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop4.Model.Entities
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
