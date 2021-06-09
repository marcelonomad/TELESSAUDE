using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelessaudeData.Models;

namespace TelessaudeData.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<int> Count();
    }
}
