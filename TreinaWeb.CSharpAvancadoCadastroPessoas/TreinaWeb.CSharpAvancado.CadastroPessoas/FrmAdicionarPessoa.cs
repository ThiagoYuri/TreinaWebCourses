using CadastroPessoas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.CadastroPessoa.Repositorio;

namespace TreinaWeb.CSharpAvancado.CadastroPessoas
{
    public partial class FrmAdicionarPessoa : Form
    {
        public FrmAdicionarPessoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = txbNome.Text,
                Idade = Convert.ToInt32(txbIdade.Text),
                Endereco = txbEndereco.Text                
            };
            IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
            repositorioPessoas.Adicionar(pessoa);
            Close();
        }
    }
}
