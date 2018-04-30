using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Seriado.AcessoADados.Dominio;

namespace Seriado.AcessoADados
{
    public class Contexto : DbContext
    {
        public DbSet<SeriadoObjeto> Seriados { get; set; }

        public Contexto(DbContextOptions options) : base(options)
        {
        }
    }
}
