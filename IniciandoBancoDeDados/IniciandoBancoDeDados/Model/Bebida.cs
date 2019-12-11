using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoBancoDeDados.Model
{
    public class Bebida // para o banco de dados ascessar tem que ter "public"
    {
        [Key]// são anotações e deve ir sempre uma linha antes do queremos "notar"
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Teor { get; set; }
        public int Ml { get; set; }
        public decimal Valor { get; set; }
    }
}
