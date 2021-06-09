using System;
using System.Collections.Generic;
using System.Text;
using TelessaudeData.Models.Enums;

namespace TelessaudeData.Models
{
    public class Telefone : BaseModel
    {
        public TipoTelefone Tipo { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
    }
}
