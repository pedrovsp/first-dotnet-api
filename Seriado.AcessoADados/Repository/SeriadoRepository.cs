using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seriado.AcessoADados.Dominio;

namespace Seriado.AcessoADados.Repository
{
    public class SeriadoRepository : ISeriadoRepository
    {
        private Contexto _contexto { get; set; }

        public SeriadoRepository(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public SeriadoObjeto Inserir(SeriadoObjeto seriadoObjeto)
        {
            _contexto.Seriados.Add(seriadoObjeto);
            _contexto.SaveChanges();
            return seriadoObjeto;
        }

        public SeriadoObjeto Editar(SeriadoObjeto seriadoObjeto)
        {
            _contexto.Seriados.Update(seriadoObjeto);
            _contexto.SaveChanges();
            return seriadoObjeto;
        }

        public void Excluir(SeriadoObjeto seriadoObjeto)
        {
            _contexto.Seriados.Remove(seriadoObjeto);
            _contexto.SaveChanges();
        }

        public SeriadoObjeto ObterPorId(Guid idSeriado)
        {
            return _contexto.Seriados.Find(idSeriado);
        }

        public ICollection<SeriadoObjeto> ObterTodos()
        {
            return _contexto.Seriados.ToList();
        }
    }
}
