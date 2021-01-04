using System.ComponentModel;
using Xamarin.Forms;
using Costea_Cosmina_lab12.ViewModels;

namespace Costea_Cosmina_lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}