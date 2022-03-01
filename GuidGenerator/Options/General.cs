using System.ComponentModel;

namespace GuidGenerator
{
    internal partial class OptionsProvider
    {
        // Register the options with these attributes on your package class:
        // [ProvideOptionPage(typeof(OptionsProvider.GeneralOptions), "GuidGenerator", "General", 0, 0, true)]
        // [ProvideProfile(typeof(OptionsProvider.GeneralOptions), "GuidGenerator", "General", 0, 0, true)]
        public class GeneralOptions : BaseOptionPage<General> { }
    }

    // Configuration details that will be made visible in Tools -> Options -> Guid Generator
    public class General : BaseOptionModel<General>
    {
        [Category("General")]
        [DisplayName("Upper case")]
        [Description("Determines if the generated GUID should be upper case.")]
        [DefaultValue(true)]
        public bool MakeUpperCase { get; set; }
    }
}
