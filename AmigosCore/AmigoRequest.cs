using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCore
{
    public class AmigoRequest
    {
        public string nome { get; set; }
        public string sobreNome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public DateTime aniversário { get; set; }
    }
}
