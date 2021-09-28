using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCore
{
    public interface IRepositorioAmigo
    {
        public void Salvar(Amigo amigo);
        public Amigo GetAmigo(Guid id);
        public IEnumerable<Amigo> GetAllAmigos();
        public void AlterarAmigo(Amigo amigo);
        public void RemoveAmigo(Guid id);
    }
}
