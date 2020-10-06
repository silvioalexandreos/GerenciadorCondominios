using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Veiculo
    {
        public int VeiculoID { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio.")]
        [MaxLength(20, ErrorMessage = "Use menos caracteres.")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatorio.")]
        [MaxLength(20, ErrorMessage = "Use menos caracteres.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio.")]
        [MaxLength(20, ErrorMessage = "Use menos caracteres.")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio.")]
        public string Placa { get; set; }
        public string UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
    }
}
