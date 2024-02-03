using System.Windows;

namespace Bubbles
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public BubblesSettings Settings { get; set; }

        public SettingsWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.RadiusMin > Settings.RadiusMax)
                Settings.RadiusMin = Settings.RadiusMax;

            if (Settings.SpeedMin > Settings.SpeedMax)
                Settings.SpeedMin = Settings.SpeedMax;

            Settings.Save(App.SettingsFile);
            Application.Current.Shutdown();
        }
    }
}
