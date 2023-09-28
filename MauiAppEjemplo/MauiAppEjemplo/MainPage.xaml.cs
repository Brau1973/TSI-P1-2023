
using MauiAppEjemplo.Servicios;

namespace MauiAppEjemplo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly IGetUsuarios _GetUsuarios;
        public MainPage(IGetUsuarios service)
        {
            InitializeComponent();
            _GetUsuarios = service;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _GetUsuarios.Obtener();
            listViewUsuarios.ItemsSource = data;

            loading.IsVisible = false;


        }
    }
}