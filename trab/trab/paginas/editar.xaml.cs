﻿using System;
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
    public partial class editar : ContentPage
    {
        public editar()
        {
            InitializeComponent();
            btn_editar.Clicked += EditarAluno;
        }
        public void EditarAluno(object sender, EventArgs args)
        {
            string cpf = txt_cpf.Text;
            string nome = txt_nome.Text;
            string ende = txt_ende.Text;
            string fone = txt_fone.Text;
            string idade = txt_idade.Text;

            Banco_funcoes dbf = new Banco_funcoes();
            dbf.CriarBancoDeDados();
            dbf.Editar(cpf, nome, ende, fone, idade);
            DisplayAlert("Mensagem", "Registro alterado com Sucesso!", "OK");
        }

    }
}