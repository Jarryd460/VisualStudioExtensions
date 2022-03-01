namespace GuidGenerator
{
    [Command(PackageIds.OpenGUIDWindow)]
    internal sealed class OpenWindowCommand : BaseCommand<OpenWindowCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            // Display the window
            await GUIDWindow.ShowAsync();
        }
    }
}
