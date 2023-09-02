using Entidades.notificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.entidades
{
    public class Base : Notifica
    {
        [Display (Name = "código")]
        public int id;

        [Display(Name = "name")]
        public string name;
    }
}
