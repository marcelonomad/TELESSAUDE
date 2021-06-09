using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelessaudeData.Models;
using TelessaudeViewModel.Models;
using TelessaudeViewModel.Models.Enums;

namespace TelessaudeView.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Paciente, PacienteViewModel>();
            CreateMap<PacienteViewModel, Paciente>();
        }
    }
}
