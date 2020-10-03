using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP04.View;
using Xamarin.Forms;

namespace TP04
{
    public partial class MainPage : ContentPage
    {
        AlunoViewModel vmAluno;
        public MainPage()
        {
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnAlunoTapped(object sender,
        ItemTappedEventArgs args)
        {
            var selecionado = args.Item as TP04.Model.Aluno;
            DisplayAlert("Aluno selecionado", "Aluno: " +
            selecionado.Id, "OK");
        }
    }
}
