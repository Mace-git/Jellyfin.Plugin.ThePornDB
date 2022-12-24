namespace ThePornDB
{
    public static class Consts
    {
        public const string BaseURL = "https://metadataapi.net";

        public const string SceneURL = BaseURL + "/scenes/{0}";

        public const string PerfomerURL = BaseURL + "/performers/{0}";

        public const string SiteURL = BaseURL + "/sites/{0}";

        public const string APIBaseURL = "https://api.metadataapi.net";

        public const string APISceneSearchURL = APIBaseURL + "/scenes?parse={0}&hash={1}";

        public const string APISceneURL = APIBaseURL + "/scenes/{0}";

        public const string APIPerfomerSearchURL = APIBaseURL + "/performers?q={0}";

        public const string APIPerfomerURL = APIBaseURL + "/performers/{0}";

        public const string APISiteSearchURL = APIBaseURL + "/sites?q={0}";

        public const string APISiteURL = APIBaseURL + "/sites/{0}";

        public static readonly string UserAgent = $"Jellyfin.Plugin.ThePornDB/{Plugin.Instance.Version}";
    }
}
