using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDMI6_TP_02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Home : ContentPage
    {
        public Page_Home()
        {
            InitializeComponent();
        }

        private async void btnSave(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };

            var detalhesContato = new Page_DetalheContato();
            detalhesContato.BindingContext = contato;
            await Navigation.PushAsync(detalhesContato);
        }
    }
}