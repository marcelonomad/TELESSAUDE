using System;
using System.Collections.Generic;
using System.Text;
using TelessaudeData.Models.Enums;

namespace TelessaudeData.Models
{
    public class Paciente : BaseModel
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public int CNS { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public string NomeMae { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public Telefone TelefonePaciente { get; set; }
        public Estado Estado { get; set; }
        public string Cidade { get; set; }
    }
}
