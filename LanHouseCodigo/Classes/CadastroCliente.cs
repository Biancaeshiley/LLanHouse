using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanHouseCodigo.Classes
{
    internal class CadastroCliente
    {
        public string nomeC { get; set; }
        public string emailC { get; set; }
        public string teleC { get; set; }
        public DateTime datNasC { get; set; }       
        public CadastroCliente()
        {

        }

        public CadastroCliente(string nomeC, string emailC, string teleC, DateTime datNasC)
        {
            this.nomeC = nomeC;
            this.emailC = emailC;
            this.teleC = teleC;
            this.datNasC = datNasC;
        }
    }
}
