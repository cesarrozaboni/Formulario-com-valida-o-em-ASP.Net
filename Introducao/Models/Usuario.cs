using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario 
    {
        [Required (ErrorMessage ="Este campo é obrigatório!")]
        public string usuNome { get; set; }
        [StringLength(50, MinimumLength =1, ErrorMessage ="Insira um texto com no maximo 50 caracteres")]
        public string usuObservacoes { get; set; }
        [Range(18, 70, ErrorMessage = "A idade deve ser de no minimo 18 e no maximo 70 anos")]
        public int usuIdade { get; set; }
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage ="Informe um email valido")]
        public string usuEmail { get; set; }
        [RegularExpression(@"[a-zA-Z]{3,15}", ErrorMessage ="Somente letras de 3 a 15 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Remote("LoginUnico", "Usuario", ErrorMessage ="Este login ja existe")]
        public string usuLogin { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string usuSenha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("usuSenha", ErrorMessage ="As senhas não se coincidem")]
        public string usuConfirmaSenha { get; set; }

    }
}