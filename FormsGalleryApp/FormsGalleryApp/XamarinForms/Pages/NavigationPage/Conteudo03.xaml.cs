using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsGalleryApp.XamarinForms.Pages.NavigationPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo03 : ContentPage
    {
        public Conteudo03()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void PopAsync(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void BackToStart(System.Object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        void InsertPage(System.Object sender, System.EventArgs e)
        {
            Navigation.InsertPageBefore(new InsertedPage(), Navigation.NavigationStack[0]);
        }

        void RemovePage(System.Object sender, System.EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}