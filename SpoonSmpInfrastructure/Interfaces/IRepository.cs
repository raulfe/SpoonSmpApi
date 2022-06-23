using SpoonSmpCore.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpoonSmpInfrastructure.Interfaces
{
    public interface IRepository<T>  where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<bool> Add(T item);
        Task<bool> Update(T item);
        Task<bool> Delete(int id);

    }
}
