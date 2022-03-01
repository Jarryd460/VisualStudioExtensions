using System.Linq;

namespace GuidGenerator
{
    [Command(PackageIds.InsertGUIDCommand)]
    internal sealed class InsertGuidCommand : BaseCommand<InsertGuidCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            // Gets the currently opened active document
            var document = await VS.Documents.GetActiveDocumentViewAsync();
            // Gets the current highilghted text or position of cursor
            var selection = document.TextView.Selection.SelectedSpans.FirstOrDefault();

            var guid = Guid.NewGuid().ToString();

            // Gets an instance of my options which holds configuration settings for my command
            var options = await General.GetLiveInstanceAsync();

            if (options.MakeUpperCase)
            {
                guid = guid.ToUpperInvariant();
            }

            // Replaces text with generated GUID
            if (selection != null)
            {
                document.TextBuffer.Replace(selection, guid);
            }
        }
    }
}
