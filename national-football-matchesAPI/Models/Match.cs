using Microsoft.EntityFrameworkCore;

namespace national_football_matchesAPI.Models
{
	[Keyless]

	public class Match
	{


		public string date { get; set; }

		public string home_team { get; set; }

		public string away_team { get; set; }

		public string home_score { get; set; }

		public string away_score { get; set; }

		public string tournament { get; set; }

		public string city { get; set; }

		public string country { get; set; }

		public string neutral { get; set; }


	}
}
