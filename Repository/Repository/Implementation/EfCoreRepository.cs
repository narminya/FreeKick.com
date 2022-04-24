using Domain.Base;
using Microsoft.EntityFrameworkCore;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Implementation
{
    public class EfCoreRepository<T> : IRepository<T> where T : class, IEntity
    {

        private readonly AppDbContext Db;
        public EfCoreRepository(AppDbContext db)
        {
            Db = db;
        }
        public async Task<bool> AddAsync(T item)
        {
            try
            {
                await Db.Set<T>().AddAsync(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

          
        }

        public async Task<bool> AddAsync(List<T> item)
        {
            try
            {
                await Db.Set<T>().AddRangeAsync(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddAsync(params T[] item)
        {
            try
            {
                await Db.Set<T>().AddRangeAsync(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(T item)
        {
            try
            {
                Db.Set<T>().Remove(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> DeleteAsync(List<T> item)
        {
            try
            {
                Db.Set<T>().RemoveRange(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(params T[] item)
        {
            try
            {
                Db.Set<T>().RemoveRange(item);
                await Db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await Db.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
           return await Db.Set<T>().FindAsync(id);
        }

        public bool Update(T item)
        {
            try
            {
                Db.Set<T>().Update(item);
                 Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(List<T> item)
        {
            try
            {
                Db.Set<T>().RemoveRange(item);
                 Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(params T[] item)
        {
            try
            {
                Db.Set<T>().RemoveRange(item);
                Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
