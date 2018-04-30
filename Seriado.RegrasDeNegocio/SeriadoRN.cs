using System;
using System.Collections.Generic;
using System.Text;
using Seriado.AcessoADados.Dominio;
using Seriado.AcessoADados.ModeloVisao;
using Seriado.AcessoADados.Repository;

namespace Seriado.RegrasDeNegocio
{
    public class SeriadoRN : ISeriadoRN
    {
        private ISeriadoRepository _seriadorepository;

        public SeriadoRN(ISeriadoRepository seriadoRepository)
        {
            this._seriadorepository = seriadoRepository;
        }

        public SeriadoObjeto Atualizar(Guid idSeriado, SeriadoModeloVisao seriadoModeloVisao)
        {
            var seriadoObjeto = _seriadorepository.ObterPorId(idSeriado);

            if (seriadoObjeto == null)
                return null;


            return seriadoObjeto;
        }

        public string Classificar(int notaPublica, int notaCritica)
        {
            if (notaPublica > 8 || notaCritica > 9)
                return "Gold";
            else if (notaPublica > 5 || notaCritica > 7)
                return "Silver";
            else
                return "Bronze";
        }

        public void Excluir(SeriadoModeloVisao seriadoModeloVisao)
        {
            throw new NotImplementedException();
        }

        public SeriadoObjeto Inserir(SeriadoModeloVisao seriadoModeloVisao)
        {
            var seriadoObjeto = new SeriadoObjeto();

            seriadoObjeto.Nome = seriadoModeloVisao.Nome;
            seriadoObjeto.QtdEpisodios = seriadoModeloVisao.QtdEpisodios;
            seriadoObjeto.Temporada = seriadoModeloVisao.Temporada;
            seriadoObjeto.Duracao = seriadoModeloVisao.Duracao;
            seriadoObjeto.AvaliacaCriticos = seriadoModeloVisao.AvaliacaCriticos;
            seriadoObjeto.AvaliacaoPublico = seriadoModeloVisao.AvaliacaoPublico;

            seriadoObjeto.Categoria = this.Classificar(seriadoObjeto.AvaliacaoPublico, seriadoObjeto.AvaliacaCriticos);

            seriadoObjeto = _seriadorepository.Inserir(seriadoObjeto);

            return seriadoObjeto;
        }

        public SeriadoObjeto Obter(Guid idSeriado)
        {
            return _seriadorepository.ObterPorId(idSeriado);
        }

        public ICollection<SeriadoObjeto> ObterTodos()
        {
            return _seriadorepository.ObterTodos();
        }
    }
}
