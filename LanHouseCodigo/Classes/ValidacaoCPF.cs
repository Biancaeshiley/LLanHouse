using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanHouseCodigo.Classes
{
    internal class ValidacaoCPF
    {
        public static bool ValidaCPF(string CPF)
        {
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            if (CPF.Length != 11)
            { 
                return false;
            }

            int s = 0;
            int n1 = 10;
            for (int i = 0; i < 9; i++)
            {
                s += Convert.ToInt32(CPF[i].ToString()) * n1;
                n1--;
            }

            int res = s % 11;

            if (res < 2)
            { 
                res = 0;
            }

            else
            { 
                res = 11 - res; 
            }

            int so = 0;
            int n2 = 11;
            for (int i = 0; i < 10; i++)
            {
                so += Convert.ToInt32(CPF[i].ToString()) * n2;
                n2--;
            }

            int res2 = so % 11;

            if (res2 < 2)
            {
                res2 = 0;
            }

            else
            { 
                res2 = 11 - (so % 11); 
            }

            if (res == Convert.ToInt32(CPF[9].ToString()) && res2 == Convert.ToInt32(CPF[10].ToString()))
            { 
                return true;
            }
                return false; 
            
        }
    }
}
    
    
