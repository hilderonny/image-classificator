using ImageClassificator.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
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

        public MainWindow()
        {
            InitializeComponent();
            var homeMenuItem = (NavigationViewItem)NavView.MenuItems.First();
            NavView.Header = homeMenuItem.Content;
            NavView.SelectedItem = homeMenuItem;
            ContentFrame.Navigate(Type.GetType(homeMenuItem.Tag.ToString()));
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
                var navPageType = Type.GetType(args.SelectedItemContainer.Tag.ToString());
                ContentFrame.Navigate(navPageType);
            }
        }

    }
}
