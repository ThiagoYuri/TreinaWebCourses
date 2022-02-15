using CadastroPessoas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Persistencia.EF
{
    public class CadastroPessoasDbContext:DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
