using System;
using System.Collections.Generic;

namespace eAgenda.Dominio
{
    public class Repositorio<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;
        protected int contadorID;

        #region Construtor
        public Repositorio()
        {
            registros = new List<T>();
        }
        #endregion

        public virtual void Inserir(T registro)
        {
            registro.id = ++contadorID;
            registros.Add(registro);
        }

        public virtual void Editar(T registroSelecionado)
        {
            foreach (var item in registros)
            {
                if (item.id == registroSelecionado.id)
                { 
                    //item.Nome = tarefaAtualizada.Titulo;
                    break;
                }
            }
            //registroSelecionado.id = idAntigo;
            //registros.Insert(registroSelecionado.id, registroSelecionado);
            //return registros.Remove(registros.Find(x => x.id == idAntigo));
        }

        public virtual bool Excluir(T registro)
        {
            return registros.Remove(registro);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }
    }
}