﻿using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Abstraction
{
   public interface IRepository<T> where T: class, IEntity
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetAsync(int id);

        Task<bool> AddAsync(T item);
        Task<bool> AddAsync(List<T> item);
        Task<bool> AddAsync(params T[] item);

        bool Update(T item);
        bool Update(List<T> item);
        bool Update(params T[] item);


        Task<bool> DeleteAsync(T item);
        Task<bool> DeleteAsync(List<T> item);
        Task<bool> DeleteAsync(params T[] item);
    }
}
