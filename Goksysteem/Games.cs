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
        public int score_team1 { get; set; }
        public int score_team2 { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public int team1_id { get; set; }
        public int team2_id { get; set; }
        public string datum { get; set; }
        public int scheidsrechter_id { get; set; }
        public int is_bewerkt { get; set; }
        public int field_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public override string ToString()
        {
            return $"{title}";
        }
    }


}
