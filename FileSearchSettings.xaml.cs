using System.Windows;
using System.Windows.Controls;

namespace Wox.Plugin.FileSearch
   {
    public partial class FileSearchSettings : UserControl
    {
        private readonly Settings _settings;

        public FileSearchSettings(Settings settings)
        {
            InitializeComponent();
            _settings = settings;
        }

        private void View_Loaded(object sender, RoutedEventArgs re)
        {
            UseLocationAsWorkingDir.IsChecked = _settings.UseLocationAsWorkingDir;

            UseLocationAsWorkingDir.Checked += (o, e) =>
            {
                _settings.UseLocationAsWorkingDir = true;
            };

            UseLocationAsWorkingDir.Unchecked += (o, e) =>
            {
                _settings.UseLocationAsWorkingDir = false;
            };
        }
    }
}
