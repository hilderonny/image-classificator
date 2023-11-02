using ImageClassificator.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Linq;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ImageClassificator
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        ObservableCollection<Category> Categories { get; set; }

        void InitializeCategories()
        {
            Categories = new ObservableCollection<Category>
            {
                new Category { Icon = Symbol.Home, Name = "Home", Page = typeof(HomePage) }
            };
            NavView.SelectedItem = Categories.First();
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeCategories();
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavView.Header = args.SelectedItemContainer.Content;
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                var selectedCategory = (Category)args.SelectedItem;
                ContentFrame.Navigate(selectedCategory.Page);
            }
        }

    }
}
