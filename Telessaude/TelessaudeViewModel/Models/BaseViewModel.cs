using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TelessaudeViewModel.Models
{
    public class BaseViewModel
    {
        [Required]
        public string Id { get; set; }
    }
}
