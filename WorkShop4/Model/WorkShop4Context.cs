using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorkShop4.Model.Entities;

namespace WorkShop4.Model
{
    public interface IWorkShop4Context : IDisposable
    {
        DbSet<T> GetDbSet<T>() where T : class, IBaseEntity;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DatabaseFacade Database { get; }
    }
    public class WorkShop4Context : DbContext, IWorkShop4Context
    {
        public WorkShop4Context(DbContextOptions<WorkShop4Context> options) : base (options)
        {
            
        }



        public DbSet<T> GetDbSet<T>() where T : class, IBaseEntity => Set<T>();

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
