using System;

namespace AmigosCore
{
    public class Amigo
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string sobreNome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public DateTime aniversário { get; set; }
    }
}
