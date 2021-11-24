using Xamarin.Forms;

namespace FormsGalleryApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(
            //    new XamarinForms.Pages.NavigationPage.Conteudo01()
            //);
            //MainPage = pagina;

            //var page = new CarouselPage();
            //page.Children.Add(new XamarinForms.Pages.NavigationPage.Conteudo01());
            //page.Children.Add(new XamarinForms.Pages.NavigationPage.Conteudo02());
            //page.Children.Add(new XamarinForms.Pages.NavigationPage.Conteudo03());

            MainPage = new AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
