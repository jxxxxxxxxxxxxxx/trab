using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using trab.banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trab.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inserir : ContentPage
    {
        public String text;
        public inserir()
        {
            InitializeComponent();
            btn_enviar.Clicked += cadastrar;
        }
        void cpfMask(object sender, EventArgs e)
        {
            var ev = e as TextChangedEventArgs;

            if (ev.NewTextValue != ev.OldTextValue)
            {
                var entry = (Entry)sender;
                text = Regex.Replace(ev.NewTextValue, @"[^0-9]", "");

                text = text.PadRight(11);

                // removendo todos os digitos excedentes 
                if (text.Length > 11)
                {
                    text = text.Remove(11);
                }

                text = text.Insert(3, ".").Insert(7, ".").Insert(11, "-").TrimEnd(new char[] { ' ', '.', '-' });
                if (entry.Text != text)
                {
                    entry.Text = text; }

            }
        }
        public void cadastrar(object sender, EventArgs args)
        {
            string cpf = text;
            string nome = txt_nome.Text;
            string ende = txt_ende.Text;
            string fone = txt_fone.Text;
            string idade = txt_idade.Text;
            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.Inserir(cpf, nome, ende, fone, idade);
            DisplayAlert("Mensagem", "Registro gravado com Sucesso!", "OK");
        }
    
    }
}