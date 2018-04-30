using Seriado.AcessoADados.Dominio;
using Seriado.AcessoADados.ModeloVisao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seriado.RegrasDeNegocio
{
    public interface ISeriadoRN
    {
        SeriadoObjeto Inserir(SeriadoModeloVisao seriadoModeloVisao);
        SeriadoObjeto Atualizar(Guid idSeriado, SeriadoModeloVisao seriadoModeloVisao);
        void Excluir(SeriadoModeloVisao seriadoModeloVisao);
        SeriadoObjeto Obter(Guid idSeriado);
        ICollection<SeriadoObjeto> ObterTodos();

        string Classificar(int notaPublica, int notaCritica);
    }
}
