using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoClienteASPMVC.Areas.Cliente.Models
{
    public class AccountCliente
    {
        public String UserId { get; set; }
        [DataType(DataType.Password)]
        public String Senha { get; set; }
    }
}