using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Security.Cryptography.X509Certificates;

namespace PDMI6_TP_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnEstiloPadrão(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloPadrao());
        }

        async void btnEstiloDinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloDinamico());
        }

        async void btnEventTriggers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_EstiloEventTriggers());
        }

        async void btnHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_Home());
        }


        async void btnViewSimples(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = "Nikolas Caldeira  / Lucas Henrique",
                Idade = 25,
                Profissao = "Programador Back-end e Programador Front-end",
                Pais = "Brasil",
            };
            var detalhePage = new Page_viewSimples();
            detalhePage.BindingContext = contato;
            await Navigation.PushAsync(detalhePage);
        }

        async void btnProduto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_Produto());
        }
    }
}
