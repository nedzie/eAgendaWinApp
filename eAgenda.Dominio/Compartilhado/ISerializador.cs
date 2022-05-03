using System.Collections.Generic;

namespace eAgenda.Dominio.Compartilhado
{
    public interface ISerializador<T> where T : class
    {
        List<T> Carregar();
        void Salvar(List<T> x);
    }
}