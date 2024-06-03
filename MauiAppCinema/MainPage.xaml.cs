using MauiAppCinema.categorias.Animacao;
using MauiAppCinema.categorias.Aventura;
using MauiAppCinema.categorias.Comedia;
using MauiAppCinema.categorias.Documentario;
using MauiAppCinema.categorias.Drama;
using MauiAppCinema.categorias.Ficcao;
using MauiAppCinema.categorias.Guerra;
using MauiAppCinema.categorias.Infantil;
using MauiAppCinema.categorias.Nacional;
using MauiAppCinema.categorias.Romance;
using MauiAppCinema.categorias.Suspense;
using MauiAppCinema.categorias.Terror;

namespace MauiAppCinema
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new MainAventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }
        }

        private void comedia_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainComedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void drama_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainDrama());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void terror_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainTerror());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void ficcao_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainFiccao());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void suspense_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainSuspense());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void infantil_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainInfantil());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void animacao_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainAnimacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void documentario_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainDocumentario());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void guerra_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainGuerra());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void nacional_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainNacional());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }

        private void romance_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new MainRomance());
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Ok");
            }

        }
    }

}
