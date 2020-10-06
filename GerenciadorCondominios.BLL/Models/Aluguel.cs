﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Aluguel
    {
        public int AluguelId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "Valor inválido.")]
        public decimal Valor { get; set; }
        [Display (Name="Mês")]
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatorio.")]
        [Range(2020, 2030, ErrorMessage = "Valor inválido.")]
        public int Ano { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
