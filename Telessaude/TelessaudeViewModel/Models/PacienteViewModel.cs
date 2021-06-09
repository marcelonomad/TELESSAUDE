using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TelessaudeViewModel.Models.Enums;

namespace TelessaudeViewModel.Models
{
    public class PacienteViewModel : BaseViewModel
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        [Required]
        public int CPF { get; set; }
        [Display(Name = "RG")]
        public int RG { get; set; }
        [Display(Name = "CNS")]
        public int CNS { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Sexo")]
        public Sexo Sexo { get; set; }
        [Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }
        [Display(Name = "CEP")]
        public int CEP { get; set; }
        public TelefoneViewModel TelefonePaciente { get; set; }
        [Display(Name = "UF")]
        public Estado Estado { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
    }
}
