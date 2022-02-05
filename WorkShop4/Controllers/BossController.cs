using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;
using WorkShop4.Model.Entities;
using WorkShop4.Services;

namespace WorkShop4.Controllers
{
    public class BossController : BaseController<Boss, BossDto>
    {
        public BossController(IBossService bossService) : base (bossService)
        {

        }
    }
}
