using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;

namespace trab.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Masterr : Xamarin.Forms.MasterDetailPage
    {
        public Masterr()
        {
            InitializeComponent();
        }

        private void GoPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new trab.paginas.inserir());
        }
        private void GoPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new trab.paginas.lista());
        }
        private void GoPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new trab.paginas.pesquisar());
        }
        private void GoPagina4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new trab.paginas.editar());
        }
        private void GoPagina5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new trab.paginas.excluir());
        }
        private void GoPagina6(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new trab.paginas.sobre());
        }
    }
}