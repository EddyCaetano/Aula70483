using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerPessoaMaiorIdade.Classes
{
    class Pessoa
    {
        public string NomeCompleto { get; set; }
        public DateTime Data { get; set; }
        public string BebidaAlcoolica { get { return PodeBeber(); } }

        private string PodeBeber()
        {
            if((2019 - Data.Year) >= 18)
            {
                return "Pode Beber!";
            }
            else
            {
                return "Só leite ninho pra vc!";
            }
        }
    }
}
