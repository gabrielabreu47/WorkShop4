using AutoMapper;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;
using WorkShop4.Model;
using WorkShop4.Model.Entities;

namespace WorkShop4.Services
{
    public interface IBossService : IBaseService<Boss, BossDto>
    {
        Task<string> SayHello();
    }

    public class BossService : BaseService<Boss, BossDto>, IBossService
    {
        public BossService(IWorkShop4Context workShop4Context, IMapper mapper) 
            : base (workShop4Context, mapper)
        {

        }

        public async Task<string> SayHello()
        {
            return "Hello";
        }
    }
}
