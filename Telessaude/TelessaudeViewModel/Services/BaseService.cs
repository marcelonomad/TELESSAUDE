using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelessaudeData.Models;
using TelessaudeData.Repositories.Interfaces;
using TelessaudeViewModel.Services.Interfaces;

namespace TelessaudeViewModel.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public void AddOrUpdate(T entry)
        {
            var targetRecord = _repository.GetById(entry.Id).Result;

            if (targetRecord != null)
            {
                _repository.Update(entry);
                return;
            }

            _repository.Insert(entry);
        }

        public void Remove(Guid id)
        {
            var label = _repository.GetById(id).Result;
            _repository.Delete(label);
        }
    }
}
