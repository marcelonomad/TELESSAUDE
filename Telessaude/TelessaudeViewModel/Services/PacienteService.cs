using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelessaudeData.Models;
using TelessaudeViewModel.Models;
using TelessaudeViewModel.Services.Interfaces;

namespace TelessaudeViewModel.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IBaseService<Paciente> _service;
        private readonly IMapper _mapper;

        public PacienteService(IBaseService<Paciente> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PacienteViewModel>> GetAsync()
        {
            var pacientes = await _service.GetAsync();
            var result = pacientes.Select(t => _mapper.Map<Paciente, PacienteViewModel>(t)).ToList();
            return result;
        }

        public async Task<PacienteViewModel> GetById(string id)
        {
            var guid = new Guid(id);
            return _mapper.Map<Paciente, PacienteViewModel>(await _service.GetById(guid));
        }

        public void AddOrUpdate(PacienteViewModel model)
        {
            _service.AddOrUpdate(_mapper.Map<PacienteViewModel, Paciente>(model));
        }

        public void Remove(string id)
        {
            var guid = new Guid(id);
            _service.Remove(guid);
        }
    }
}
