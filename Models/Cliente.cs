using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace ExeKayqueIV.Models
{
    public class Cliente
    {
        [DisplayName("Código do Cliente")]
        [Required(ErrorMessage = "O código do clinte é obrigatório")]
        public int IdCli { get; set; }

        [StringLength(150, MinimumLength = 1, ErrorMessage = "O nome deve conter no maximo 150 caracteres")]
        [DisplayName("Nome do Clinte ")]
        [Required(ErrorMessage = "O nome do Clinte é Obrigatorio")]
        public string NomeCli { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [DisplayName("CPF")]
        [System.Web.Mvc.Remote("SelectCPF", "Home", ErrorMessage = "o cpf já existe")]
        public string CPF { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Digite um e-mail válido")]
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        public string Email { get; set; }

        [StringLength(15, MinimumLength = 1, ErrorMessage = "O nome deve conter no maximo 15 caracteres")]
        [DisplayName("Login")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [System.Web.Mvc.Remote("SelectLogin", "Home", ErrorMessage = "o login já existe")]
        public string Login { get; set; }


        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [DisplayName("Senha")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        [DisplayName("Confirme a senha: ")]
        [Required(ErrorMessage = "A confirmação da senha é obrigatória")]
        public string ConfirmaSenha { get; set; }


        [DataType(DataType.Date)]
        [System.Web.Mvc.Remote("SelectDate", "Home", ErrorMessage = "A data deve ser igual ou superior a data de hoje")]
        public string DataCadastro { get; set; }
    }
}