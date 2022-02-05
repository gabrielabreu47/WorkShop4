using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;
using WorkShop4.Model;
using WorkShop4.Model.Entities;

namespace WorkShop4.Services
{
    public interface IBaseService<T,TDto> where T : IBaseEntity where TDto : BaseDto
    {
        IQueryable<T> Get();
        Task<TDto> Create(TDto dto);
        Task<TDto> Update(int id, TDto dto);
        Task<TDto> GetById(int id);
        Task<bool> Delete(int id);
    }

    public class BaseService<T,TDto> : IBaseService<T,TDto> where T : BaseEntity where TDto : BaseDto
    {
        protected readonly IWorkShop4Context _context;
        protected readonly IMapper _mapper;
        protected readonly DbSet<T> _dbSet;

        public BaseService(IWorkShop4Context context, IMapper mapper)
        {
            _dbSet = context.GetDbSet<T>();
            _context = context;
            _mapper = mapper;
        }

        public IQueryable<T> Get()
        {
            return _dbSet.AsQueryable();   
        }

        public async Task<TDto> Create(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);

            _dbSet.Add(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }

        public async Task<TDto> Update(int id, TDto dto)
        {
            var entity = await _dbSet.FindAsync(id);

            if(entity == null)
            {
                return null; 
            }

            entity = _mapper.Map(dto, entity);

            _dbSet.Update(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }

        public async Task<TDto> GetById(int id)
        {
            var entity = await Get()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefaultAsync();

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await Get()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefaultAsync();

            if(entity is null)
            {
                return false;
            }

            _dbSet.Remove(entity);

            await _context.SaveChangesAsync();

            return true;
        }

        
    }
}
