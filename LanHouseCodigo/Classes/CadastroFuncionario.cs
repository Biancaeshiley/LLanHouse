using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanHouseCodigo.Classes
{
    internal class CadastroFuncionario
    {
        public string nomeF { get; set; }
        public string numBF { get; set; }
        public string endF { get; set; }
        public string emalF { get; set; }
        public string CpfF { get; set; }
        public string teleF { get; set; }
        public DateTime dtNasF { get; set; }

        public CadastroFuncionario()
        {

        }

        public CadastroFuncionario(string nomeF, string numBF, string endF, string emalF, string cpfF, string teleF, DateTime dtNasF)
        {
            this.nomeF = nomeF;
            this.numBF = numBF;
            this.endF = endF;
            this.emalF = emalF;
            CpfF = cpfF;
            this.teleF = teleF;
            this.dtNasF = dtNasF;
        }
    }
}
