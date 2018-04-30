using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Seriado.AcessoADados.Dominio
{
    public class SeriadoObjeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Temporada { get; set; }
        public float Duracao { get; set; }
        public int QtdEpisodios { get; set; }
        public int AvaliacaCriticos { get; set; }
        public int AvaliacaoPublico { get; set; }
        public string Categoria { get; set; }
    }
}
