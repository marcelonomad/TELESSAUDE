using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelessaudeViewModel.Models;

namespace TelessaudeViewModel.Services.Interfaces
{
    public interface IPacienteService
    {
        void AddOrUpdate(PacienteViewModel model);
        Task<IEnumerable<PacienteViewModel>> GetAsync();
        Task<PacienteViewModel> GetById(string id);
        void Remove(string id);
    }
}
