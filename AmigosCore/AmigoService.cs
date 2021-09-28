using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCore
{
    public class AmigoService
    {
        private IRepositorioAmigo RepositorioAmigo { get; }

        public AmigoService(IRepositorioAmigo repositorioAmigo)
        {
            RepositorioAmigo = repositorioAmigo;
        }

        public Amigo GetAmigo(Guid id)
        {
            Amigo amigo = RepositorioAmigo.GetAmigo(id);

            return amigo;
        }

        public IEnumerable<Amigo> GetTodosAmigos()
        {
            return RepositorioAmigo.GetAllAmigos();
        }

        public Amigo CadastrarAmigo(AmigoRequest amigoCadastro)
        {
            var amigo = new Amigo();
            amigo.nome = amigoCadastro.nome;
            amigo.sobreNome = amigoCadastro.sobreNome;
            amigo.email = amigoCadastro.email;
            amigo.telefone = amigoCadastro.telefone;
            amigo.aniversário = amigoCadastro.aniversário;

            RepositorioAmigo.Salvar(amigo);
            return amigo;
        }

        public Amigo AlterarAmigo(Guid id, AmigoRequest amigoAlterar)
        {
            var amigo = RepositorioAmigo.GetAmigo(id);

            amigo.nome = amigoAlterar.nome;
            amigo.sobreNome = amigoAlterar.sobreNome;
            amigo.email = amigoAlterar.email;
            amigo.telefone = amigoAlterar.telefone;
            amigo.aniversário = amigoAlterar.aniversário;

            RepositorioAmigo.AlterarAmigo(amigo);
            return amigo;
        }

        public void RemoverAmigo(Guid id)
        {
            RepositorioAmigo.RemoveAmigo(id);
        }
    }
}
