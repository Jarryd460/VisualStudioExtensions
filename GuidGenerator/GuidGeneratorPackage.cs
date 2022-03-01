global using Community.VisualStudio.Toolkit;
global using Microsoft.VisualStudio.Shell;
global using System;
global using Task = System.Threading.Tasks.Task;
using System.Runtime.InteropServices;
using System.Threading;

namespace GuidGenerator
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.GuidGeneratorString)]
    // Adds options menu under Tools -> Options, called Guid Generator
    [ProvideOptionPage(typeof(OptionsProvider.GeneralOptions), "Guid Generator", "General", 0, 0, true)]
    [ProvideProfile(typeof(OptionsProvider.GeneralOptions), "Guid Generator", "General", 0, 0, true)]
    // Adds tool window which will be picked up by RegisterToolWindows
    [ProvideToolWindow(typeof(GUIDWindow.Pane))]
    public sealed class GuidGeneratorPackage : ToolkitPackage
    {
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.RegisterCommandsAsync();

            // Lets Visual Studio know about tool windows
            this.RegisterToolWindows();
        }
    }
}