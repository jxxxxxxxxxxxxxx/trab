using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trab.banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trab.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lista : ContentPage
    {
        public lista()
        {
            InitializeComponent();
            btn_recarregar.Clicked += listar;
        }
        public void listar(object sender, EventArgs args)
        {
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            List<Clientes> listaclientes = new List<Clientes>();
            listaclientes = dbf.GetClientes();
            var array = listaclientes.ToArray();
            List<Clientes> lista = new List<Clientes>();
            for (int c = 0; c < array.Length; c++)
            {
                lista.Add(new Clientes
                {
                    CPF = array[c].CPF.ToString(),
                    Nome = array[c].Nome.ToString(),
                    Ende = array[c].Ende.ToString(),
                    Fone = array[c].Fone.ToString(),
                    Idade = array[c].Idade
                });
            }
            ls_clientes.ItemsSource = lista;
        }
    }
}