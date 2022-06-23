using Microsoft.EntityFrameworkCore;
using SpoonSmpCore.Filters;
using SpoonSmpCore.Models.Base;
using SpoonSmpInfrastructure.Context;
using SpoonSmpInfrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpoonSmpInfrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly haguayContext _context;
        private readonly DbSet<T> _entities;
        public Repository(haguayContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task<bool> Add(T item)
        {
            try
            {
                _entities.Add(item);
                var response = await _context.SaveChangesAsync();
                return response > 0;
            }
            catch (Exception e)
            {

                throw new BusinessException($"Exception : {e.Message}");
            }
            
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var i = await GetById(id);
                _entities.Remove(i);
                var response = await _context.SaveChangesAsync();
                return response > 0;
            }
            catch (Exception e)
            {

                throw new BusinessException($"Exception : {e.Message}");
            }
            
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return await _entities.ToListAsync();
            }
            catch (Exception e)
            {

                throw new BusinessException($"Exception : {e.Message}");
            }
            
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _entities.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception e)
            {

                throw new BusinessException($"Exception : {e.Message}");
            }
            
        }

        public async Task<bool> Update(T item)
        {
            try
            {
                _entities.Update(item);
                var response = await _context.SaveChangesAsync();
                return response > 0;
            }
            catch (Exception e)
            {

                throw new BusinessException($"Exception : {e.Message}");
            }
            
        }
    }
}
