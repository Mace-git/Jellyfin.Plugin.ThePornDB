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

            this.DisableMediaAutoIdentify = false;
            this.DisableActorsAutoIdentify = false;
            
            this.ActorsOverview = 1;
            this.ActorsOverviewFormat = "<strong style="color:#ff0000">{Measurements}<br/></strong>{Cupsize}-{Waist}-{Hips}<br/>{Tattoos}<br/>{Piercings}<br/>{Bio}";
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

        public bool DisableMediaAutoIdentify { get; set; }
        public bool DisableActorsAutoIdentify { get; set; }
        
        public int ActorsOverview { get; set; }
        public string ActorsOverviewFormat { get; set; }
    }
}
