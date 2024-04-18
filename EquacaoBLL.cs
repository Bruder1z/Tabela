using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinotabela
{
    class EquacaoBLL
    {
        public static bool validaDados(Equacao _equacao)
        {
            Erro.setErro(false);

            
            if (_equacao.getA().Length == 0)
            {
                Erro.setErro("O valor de A é obrigatório.");
                return false;
            }

            
            if (!float.TryParse(_equacao.getA(), out _))
            {
                Erro.setErro("O valor de A deve ser numérico!");
                return false;
            }

            
            if (_equacao.getB().Length == 0)
            {
                Erro.setErro("O valor de B é obrigatório.");
                return false;
            }

            
            if (!float.TryParse(_equacao.getB(), out _))
            {
                Erro.setErro("O valor de B deve ser numérico!");
                return false;
            }

           
            return true;
        }
    }

}