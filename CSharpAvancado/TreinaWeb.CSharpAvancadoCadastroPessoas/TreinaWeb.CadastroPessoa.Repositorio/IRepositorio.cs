using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CadastroPessoa.Repositorio
{
    public interface IRepositorio<TTpo>
    {
        List<TTpo> SelecionarTodos();
        int Adicionar(TTpo objeto);
    }
}
