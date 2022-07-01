using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ThePornDB.Helpers
{
    class ActorsOverview
    {
        public static string CustomFormat(string Gender, JObject Data)
        {
            string overview = "";
            string[] extraList;
            string[] extrasMeta = { "gender", "birthday", "birthplace", "birthplace_code", "active", "astrology", "ethnicity", "nationality", "hair_colour", "weight", "height", "measurements", "cupsize", "tattoos", "piercings", "waist", "hips" };
            

            switch (Gender)
            {

                case "Male":
                    {
                        extraList = Plugin.Instance.Configuration.ActorsOverviewFormatMale.Split(",");
                        break;
                    }
                case "Female":
                    {
                        extraList = Plugin.Instance.Configuration.ActorsOverviewFormatFemale.Split(",");
                        break;
                    }
                default:
                    {
                        extraList = Plugin.Instance.Configuration.ActorsOverviewFormat.Split(",");
                        break;
                    }
            }

            foreach (string extra in extraList)
            {
                if (extra.Contains('<') & (extra.Contains('>') == true)
                {
                    overview += extra;
                }
                else
                {
                    if (extrasMeta.Contains(extra) == true)
                    {
                        if (!string.IsNullOrEmpty((string)Data["extras"][extra]))
                        {
                            overview += string.Concat(extra[0].ToString().ToUpper(), extra.AsSpan(1), " : ");
                            overview += (string)Data["extras"][extra] + " ";
                        }
                    }
                }
            }
            return overview;
        }  
    }
}

