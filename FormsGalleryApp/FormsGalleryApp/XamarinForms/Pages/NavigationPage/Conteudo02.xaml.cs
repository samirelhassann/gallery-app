using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsGalleryApp.XamarinForms.Pages.NavigationPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo02 : ContentPage
    {
        public Conteudo02()
        {
            InitializeComponent();
        }

        private void PopAsync(object sender, EventArgs e)
        {
            
            Navigation.PopAsync();
        }

        private void PushAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conteudo03());
        }
    }
}