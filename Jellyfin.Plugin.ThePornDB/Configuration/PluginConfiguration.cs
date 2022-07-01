using MediaBrowser.Model.Plugins;

namespace ThePornDB.Configuration
{
    public enum StudioStyle
    {
        Site = 0,
        Network = 1,
        Both = 2,
    }

    public class PluginConfiguration : BasePluginConfiguration
    {
        public PluginConfiguration()
        {
            this.MetadataAPIToken = string.Empty;

            this.UseFilePath = true;
            this.UseOSHash = true;

            this.AddCollectionToCollections = true;
            this.StudioStyle = StudioStyle.Both;

            this.UseCustomTitle = false;
            this.CustomTitle = "{studio}: {title} ({actors})";

            this.UseUnmatchedTag = false;
            this.UnmatchedTag = "Missing From ThePornDB";

            this.DisableActorsAutoIdentify = false;
            
            this.ActorsOverview = "Default";
            this.ActorsOverviewFormat = "measurements";
            this.ActorsOverviewFormatMale = "measurements";
            this.ActorsOverviewFormatFemale = "measurements";
        }

        public string MetadataAPIToken { get; set; }

        public bool UseFilePath { get; set; }

        public bool UseOSHash { get; set; }

        public bool AddCollectionToCollections { get; set; }

        public StudioStyle StudioStyle { get; set; }

        public bool UseCustomTitle { get; set; }

        public string CustomTitle { get; set; }

        public bool UseUnmatchedTag { get; set; }

        public string UnmatchedTag { get; set; }

        public bool DisableActorsAutoIdentify { get; set; }
        
        public string ActorsOverview { get; set; }
        
        public string ActorsOverviewFormat { get; set; }
        
        public string ActorsOverviewFormatMale { get; set; }
        
        public string ActorsOverviewFormatFemale { get; set; }
    }
}
