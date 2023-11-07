using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ImageClassificator.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public Dictionary<string, string> Languages { get; } = Dictionaries.Languages;

        readonly ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;

        public SettingsPage()
        {
            InitializeComponent();
            LoadSettings();
        }

        private async Task<string> SelectFolder()
        {
            FolderPicker folderPicker = new();
            var window = (Application.Current as App)?.m_window as MainWindow;
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WinRT.Interop.InitializeWithWindow.Initialize(folderPicker, hWnd);
            StorageFolder selectedFolder = await folderPicker.PickSingleFolderAsync();
            return selectedFolder?.Path;
        }

        private void LoadSettings()
        {
            SettingsInputPath.Description = settings.Values["InputPath"] as string;
            SettingsProcessingPath.Description = settings.Values["ProcessingPath"] as string;
            SettingsOutputPath.Description = settings.Values["OutputPath"] as string;
            if (settings.Values["TagLanguage"] is not string selectedLanguage)
            {
                selectedLanguage = "de";
                settings.Values["TagLanguage"] = selectedLanguage;
            }
            SettingsTagLanguageComboBox.SelectedIndex = Languages.Keys.ToList().IndexOf(selectedLanguage);
        }

        private void SettingsTagLanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            settings.Values["TagLanguage"] = SettingsTagLanguageComboBox.SelectedValue;
        }

        private async void SettingsSelectInputPathButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedFolder = await SelectFolder();
            if (selectedFolder != null)
            {
                settings.Values["InputPath"] = selectedFolder;
                SettingsInputPath.Description = selectedFolder;
            }
        }

        private async void SettingsSelectProcessingPathButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedFolder = await SelectFolder();
            if (selectedFolder != null)
            {
                settings.Values["ProcessingPath"] = selectedFolder;
                SettingsProcessingPath.Description = selectedFolder;
            }
        }

        private async void SettingsSelectOutputPathButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedFolder = await SelectFolder();
            if (selectedFolder != null)
            {
                settings.Values["OutputPath"] = selectedFolder;
                SettingsOutputPath.Description = selectedFolder;
            }
        }
    }
}
