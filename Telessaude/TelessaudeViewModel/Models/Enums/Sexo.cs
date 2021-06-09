using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TelessaudeViewModel.Models.Enums
{
    public enum Sexo
    {
        [Display(Name = "Masculino")]
        Masculino,
        [Display(Name = "Feminino")]
        Feminino
    }
}
