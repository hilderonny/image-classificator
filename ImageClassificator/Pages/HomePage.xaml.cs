using Microsoft.UI.Xaml.Controls;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ImageClassificator.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {

        readonly ApplicationDataContainer settings = ApplicationData.Current.LocalSettings;

        public HomePage()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            HomeInputPathText.Text = settings.Values["InputPath"] as string;
            HomeProcessingPathText.Text = settings.Values["ProcessingPath"] as string;
            HomeOutputPathText.Text = settings.Values["OutputPath"] as string;
            if (settings.Values["TagLanguage"] is not string selectedLanguage)
            {
                selectedLanguage = "de";
                settings.Values["TagLanguage"] = selectedLanguage;
            }
            HomeTagLanguageText.Text = Dictionaries.Languages[selectedLanguage];
        }

    }
}
