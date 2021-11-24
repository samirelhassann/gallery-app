
using Xamarin.Forms;

namespace FormsGalleryApp.XamarinForms.Pages.NavigationPage
{
    public partial class InsertedPage : ContentPage
    {
        public InsertedPage()
        {
            InitializeComponent();
        }

        void OpenInitialPage(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new Xamarin.Forms.NavigationPage(new Conteudo01());
        }
    }
}
