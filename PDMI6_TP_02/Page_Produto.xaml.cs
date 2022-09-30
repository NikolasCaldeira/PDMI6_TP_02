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
    public partial class Page_Produto : ContentPage
    {
        public Page_Produto()
        {
            InitializeComponent();
        }

        private async void btnSave(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var descricao = txtDescricao.Text;
            var categoria = txtCategoria.Text;
            var quant = txtQuantidade.Text;
            var preco = txtPreco.Text;



            Produto produto = new Produto
            {
                Id = Convert.ToInt32(id),
                Descricao = descricao,
                Categoria = categoria,
                Quantidade = Convert.ToInt32(quant),
                Preco = Convert.ToDecimal(preco),
            };

            Page_DetalhesProduto detalhesProduto = new Page_DetalhesProduto();
            detalhesProduto.BindingContext = produto;

            await Navigation.PushAsync(detalhesProduto);

        }
    }
}