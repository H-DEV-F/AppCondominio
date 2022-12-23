﻿using System.ComponentModel.DataAnnotations;

namespace AdmCondominio.Api.ViewModels
{
    public class MoradorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid ApartamentoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Pets { get; set; }
    }
}
