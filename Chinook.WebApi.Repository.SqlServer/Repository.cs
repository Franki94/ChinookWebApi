﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chinook.WebApi.Repository.SqlServer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ChinookSqlContext _context;
        public Repository(ChinookSqlContext context)
        {
            _context = context;
        }

        public async Task<int> Create(T entity)
        {
            await _context.AddAsync(entity);
            return await _context.SaveChangesAsync();
        }



        public async Task<bool> Delete(T entity)
        {
            _context.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }



        public async Task<IEnumerable<T>> Read()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> ReadById(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }



        public async Task<bool> Update(T entity)
        {
            _context.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
