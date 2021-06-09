using System;
using System.Collections.Generic;
using System.Text;
using TelessaudeViewModel.Models.Enums;

namespace TelessaudeViewModel.Models
{
    public class TelefoneViewModel : BaseViewModel
    {
        public TipoTelefone Tipo { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
    }
}
