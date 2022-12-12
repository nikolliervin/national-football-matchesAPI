namespace national_football_matchesAPI.Models
{
	public class Match
	{
		public DateOnly date { get; set; }

		public string home_team { get; set; }

		public string away_team { get; set; }

		public int home_score { get; set; }

		public int away_score { get; set; }

		public string tournament { get; set; }

		public string city { get; set; }

		public string country { get; set; }


	}
}
