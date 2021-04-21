using MediaBrowser.Model.Plugins;

namespace ThePornDB.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public PluginConfiguration()
        {
            this.MetadataAPIToken = string.Empty;

            this.UseCustomTitle = false;
            this.CustomTitle = "{studio}: {title} ({actors})";
        }

        public string MetadataAPIToken { get; set; }

        public bool UseCustomTitle { get; set; }

        public string CustomTitle { get; set; }
    }
}