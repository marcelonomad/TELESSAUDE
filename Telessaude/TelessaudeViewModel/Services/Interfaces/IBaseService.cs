using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelessaudeData.Models;

namespace TelessaudeViewModel.Services.Interfaces
{
    public interface IBaseService<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAsync();

        Task<T> GetById(Guid id);

        void AddOrUpdate(T entry);

        void Remove(Guid id);
    }
}
