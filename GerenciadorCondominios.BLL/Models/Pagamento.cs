﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }

        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int AlugeulId { get; set; }
        public Aluguel Aluguel { get; set; }
        public DateTime? DataPagamento { get; set; }
        public StatusPagamento Status { get; set; }
    }

    public enum StatusPagamento
    {
        Pago, Pedente, Atrasado
    }
}
