using System;
using System.Collections.Generic;
using System.Text;

namespace Seriado.AcessoADados.ModeloVisao
{
    public class SeriadoModeloVisao
    {
        public string Nome { get; set; }
        public int Temporada { get; set; }
        public float Duracao { get; set; }
        public int QtdEpisodios { get; set; }
        public int AvaliacaCriticos { get; set; }
        public int AvaliacaoPublico { get; set; }
    }
}
