using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage ="O campo {0} é obrigatorio.")]
        [StringLength(40, ErrorMessage ="Utilize menos caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        public string Telefone { get; set; }
        public string Foto { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(40, ErrorMessage = "Utilize menos caracteres.")]
        [EmailAddress(ErrorMessage ="Digite um email valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(40, ErrorMessage = "Utilize menos caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio.")]
        [StringLength(40, ErrorMessage = "Utilize menos caracteres.")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage ="As senhas não conferem.")]
        public string SenhaConfirmada { get; set; }
    }
}
