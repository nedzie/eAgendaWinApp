using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAgenda.Dominio;

namespace eAgenda.Infra.ModuloContato
{
    public class RepositorioContato : Repositorio<Contato>, IRepositorioContato
    {
        public override void Editar(Contato contatoEscolhido)
        {
            foreach (Contato contato in registros)
            {
                if (contato.id == contatoEscolhido.id)
                {
                    contato.Nome = contatoEscolhido.Nome;
                    contato.Email = contatoEscolhido.Email;
                    contato.Telefone = contatoEscolhido.Telefone;
                    contato.Empresa = contatoEscolhido.Empresa;
                    contato.Cargo = contatoEscolhido.Cargo;
                    break;
                }
            }
        }
    }
}