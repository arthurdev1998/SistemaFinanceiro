using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.notificacoes
{
    public class Notifica
    {

        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }
        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes;
        public bool ValidarPropriedadedeString(string valor, string nomepropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                notificacoes.Add(new Notifica { NomePropriedade = nomepropriedade, Mensagem = "Campo obrigatorio" }
        );

                return false;
            }
            return true;
        }


        public bool ValidarPropriedadedeInt(int valor, string nomepropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                notificacoes.Add(new Notifica { NomePropriedade = nomepropriedade, Mensagem = "Campo obrigatorio" }
        );

                return false;
            }
            return true;
        }
    }


}


