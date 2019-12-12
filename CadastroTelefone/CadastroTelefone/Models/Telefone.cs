﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroTelefone.Models
{
    public class Telefone
    {
        [Key]
        public int Id { get; set; }
        public string Numero { get; set; }
    }
}
