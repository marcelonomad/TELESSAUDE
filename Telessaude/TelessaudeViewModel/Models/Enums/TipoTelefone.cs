using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TelessaudeViewModel.Models.Enums
{
    public enum TipoTelefone
    {
        [Display(Name = "Residencial")]
        Residencial,
        [Display(Name = "Celular")]
        Celular,
        [Display(Name = "Comercial")]
        Comercial
    }
}
