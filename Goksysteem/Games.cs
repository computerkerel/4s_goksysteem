using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goksysteem
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Games
    {
        public int id { get; set; }
        public string title { get; set; }
        public int team1_id { get; set; }
        public string team1_naam { get; set; }
        public int team1_score { get; set; }
        public int team2_id { get; set; }
        public string team2_naam { get; set; }
        public int team2_score { get; set; }
        public string datum { get; set; }
        public int scheidsrechter_id { get; set; }
        public string scheidsrechter_naam { get; set; }
        public int veld_id { get; set; }
        public string veld_naam { get; set; }

        public override string ToString()
        {
            return $"{team1_naam} - {team2_naam}";
        }
    }


}
