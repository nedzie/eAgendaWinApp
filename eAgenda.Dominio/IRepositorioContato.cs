using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio
{
    public interface IRepositorioContato
    {
        public void Editar(Contato contatoSelecionado);
    }
}