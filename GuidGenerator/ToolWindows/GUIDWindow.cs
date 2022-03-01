using Microsoft.VisualStudio.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GuidGenerator
{
    public class GUIDWindow : BaseToolWindow<GUIDWindow>
    {
        public override string GetTitle(int toolWindowId) => "GUID Window";

        public override Type PaneType => typeof(Pane);

        public override Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
        {
            return Task.FromResult<FrameworkElement>(new GUIDWindowControl());
        }

        [Guid("7a767094-bae7-43d6-9ab3-656dc33c1e28")]
        internal class Pane : ToolWindowPane
        {
            public Pane()
            {
                // The icon to dispay in the menu (View > Other Windows > Insert GUID Window)
                BitmapImageMoniker = KnownMonikers.PasteAppend;
            }
        }
    }
}
