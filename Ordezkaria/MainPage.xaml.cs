using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Ordezkaria
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> names;

        public MainPage()
        {
            InitializeComponent();
            names = new ObservableCollection<string>();
           IzenakListView.ItemsSource = names; // Asignar la fuente de datos al ListView
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            string name = izenaEntry.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                names.Add(name); // Añadir el nombre a la colección
                izenaEntry.Text = string.Empty; // Limpiar el Entry
            }
        }
    }
}
