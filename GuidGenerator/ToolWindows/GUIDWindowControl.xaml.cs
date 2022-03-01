using System.Windows;
using System.Windows.Controls;

namespace GuidGenerator
{
    public partial class GUIDWindowControl : UserControl
    {
        public GUIDWindowControl()
        {
            InitializeComponent();
        }

        private void GenerateGUID_Click(object sender, RoutedEventArgs e)
        {
            // Executes the Generate GUID command when button is clicked
            VS.Commands.ExecuteAsync(PackageGuids.GuidGenerator, PackageIds.InsertGUIDCommand).FireAndForget();
        }
    }
}
