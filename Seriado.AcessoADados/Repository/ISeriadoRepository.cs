using Seriado.AcessoADados.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seriado.AcessoADados.Repository
{
    public interface ISeriadoRepository
    {

        SeriadoObjeto Inserir(SeriadoObjeto seriadoObjeto);
        SeriadoObjeto Editar(SeriadoObjeto seriadoObjeto);
        void Excluir(SeriadoObjeto seriadoObjeto);
        SeriadoObjeto ObterPorId(Guid idSeriado);
        ICollection<SeriadoObjeto> ObterTodos();
    }
}
